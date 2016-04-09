using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {
    public GameObject playerTarget;
    public GameObject bullet;
    public GameObject cannon;
    public float repetition;
    PlayerDetection playerC;
    bool isInAction = false;
    bool newShoot = true;
    int timer = 0;
    // Use this for initialization
    void Start () {
        playerC = GetComponent<PlayerDetection>();
        playerTarget = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
	    if(playerC.isDetected && !isInAction)
        {
            isInAction = true;
            StartCoroutine(ShootTime()); 
        }
        if(isInAction)
        {
            transform.LookAt(playerTarget.transform.position);
            if(newShoot)
            {
                newShoot = false;
                StartCoroutine(ShootingDelay());
            }
        }
	}

    void Shooting()
    {
        GameObject newBullet = Instantiate(bullet);
        newBullet.transform.position = cannon.transform.position;
        newBullet.transform.rotation = cannon.transform.rotation;
    }

    IEnumerator ShootTime()
    {
        yield return new WaitForSeconds(15f);
        isInAction = false;
        playerC.ChangeDetection();
        yield return new WaitForEndOfFrame();
    }
    IEnumerator ShootingDelay()
    {
        yield return new WaitForSeconds(repetition);
        
        Shooting();
        newShoot = true;
    }

}
