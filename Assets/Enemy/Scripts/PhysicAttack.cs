using UnityEngine;
using System.Collections;

public class PhysicAttack : MonoBehaviour {
    public GameObject playerTarget;

    PlayerDetector playerC;

    public int timer = 1;

    bool isInAction = false;
    // Use this for initialization
    void Start () {
        playerC = GetComponent<PlayerDetector>();
        playerTarget = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
	    if (playerC.isClose)
        {
            isInAction = true;
            StartCoroutine(TimerToRest());
        }

        if(isInAction)
        {
            //transform.LookAt(playerTarget.transform.position);
        }
	}

    IEnumerator TimerToRest ()
    {
        yield return new WaitForSeconds(timer);
        isInAction = false;
        playerC.ChangeDetection();
        yield return new WaitForEndOfFrame();
    }
}
