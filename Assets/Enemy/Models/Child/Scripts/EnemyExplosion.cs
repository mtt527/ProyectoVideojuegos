using UnityEngine;
using System.Collections;

public class EnemyExplosion : MonoBehaviour {
    public GameObject playerTarget;
    PlayerDetection playerC;
    public float speed = 10f;
    //bool isMoving = false;
    // Use this for initialization
    void Start () {
        playerC = GetComponent<PlayerDetection>();
        playerTarget = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if (playerC.isDetected)
        {
            //isMoving = true;
            //StartCoroutine(Active());
            //if(Vector3.Distance(playerTarget.transform.position, transform.position) > 0)
            //{
                transform.LookAt(playerTarget.transform.position);
                transform.Translate (transform.forward * speed * Time.deltaTime);
            //}
        }
        //if(isMoving)
        //{
        //    transform.LookAt(playerTarget.transform.position);
        //    transform.position += transform.forward * speed * Time.deltaTime; 
        //}
    }
    //IEnumerator Active()
    //{
    //    yield return new WaitForSeconds(15f);
    //    isMoving = false;
    //    playerC.ChangeDetection();
    //    yield return new WaitForEndOfFrame();
    //}
    
}
