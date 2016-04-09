using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public int hp;
    public int damege;
    public GameObject cont;
    TotalEnemies te;

	// Use this for initialization
	void Start () {
        cont = GameObject.FindGameObjectWithTag("CameraController");
        te = cont.GetComponent<TotalEnemies>();
	}
	
	// Update is called once per frame
	void Update () {
	if(hp <= 0)
        {
            te.OnDestrction();
            Destroy(gameObject);
        }

	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            OnDamage(1);
        }
    }
    public void OnDamage(int value)
    {
        hp -= value;
    }
}
