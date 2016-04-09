using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour {
    public GameObject player;
    public GameObject exp;
    PlayerController pCon;
    Enemy eClass;
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        pCon = player.GetComponent<PlayerController>();
        eClass = gameObject.GetComponent<Enemy>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            int damage = eClass.damege;
            pCon.OnDamage(damage);
            GameObject nexExp = Instantiate(exp);
            nexExp.transform.position = transform.position;
            eClass.OnDamage(damage);
        }
    }
}
