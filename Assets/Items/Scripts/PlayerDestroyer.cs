using UnityEngine;
using System.Collections;

public class PlayerDestroyer : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if((other.gameObject.tag == "Player")&&(gameObject.tag == "Ebullet"))
        {
            Destroy(gameObject);
        }

        if ((other.gameObject.tag == "Enemy") && (gameObject.tag == "Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
