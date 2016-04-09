using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    EnemyAttributes enemy;
    float deadLine = 3f;
    public int hp;
    public int damage;
    public bool isDead;
    public bool isHurt;
	// Use this for initialization
	void Start () {
        enemy = new EnemyAttributes();
        enemy.HP = hp;
        enemy.Damage = damage;
	}
	
	// Update is called once per frame
	void Update () {
	    if(enemy.HP <= 0)
        {
            StartCoroutine(destructionDelay());
            Destroy(gameObject);
        }
	}
    void OntriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bullet")
        {
            OnDamage(2);
            isHurt = true;
        }
        else if (other.gameObject.tag == "knife")
        {
            OnDamage(1);
            isHurt = true;
        }
        else if (other.gameObject.name == "Bomb")
        {
            OnDamage(10);
            isHurt = true;
        }
    }

    void OnDamage(int ownDamage)
    {
        enemy.HP -= ownDamage;
    }

    public void OnHurt()
    {
        isHurt = false;
    }

    IEnumerator destructionDelay()
    {
        yield return new WaitForSeconds(deadLine);
        isDead = true;
    }
}
