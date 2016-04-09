using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
    public GameObject playerTarget;
    PlayerDetector playerC;
    public float speed = 10f;
    // Use this for initialization
    void Start () {
        playerC = GetComponent<PlayerDetector>();
        playerTarget = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if (playerC.isDetected)
        {
            transform.LookAt(playerTarget.transform.position);
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
}
