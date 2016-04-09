using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
    Animator anim;
    PlayerDetector playerC;
    EnemyMovement eMove;
    EnemyController eController;

    float time;
    // Use this for initialization
    void Start () {
        playerC = GetComponent<PlayerDetector>();
        eMove = GetComponent<EnemyMovement>();
        eController = GetComponent<EnemyController>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
       
            if (!eMove.waiting)
            {
                if (!playerC.isClose)
                {
                    anim.SetBool("Walk", true);
                    anim.SetBool("Attack", false);
                }
                else
                {
                    anim.SetBool("Walk", false);
                    anim.SetBool("Attack", true);
                }
            }
        else
        {
            anim.SetBool("Walk", false);
        }

        if(eController.isDead)
        {
            anim.SetTrigger("Dead");
        }
        else if (eController.isHurt)
        {
            time = Time.deltaTime;
            anim.SetTrigger("Pain");
            eController.OnHurt();
        }
        if ((time + 1f) == Time.deltaTime)
        {
            anim.ResetTrigger("Pain");
        }
    }
}
