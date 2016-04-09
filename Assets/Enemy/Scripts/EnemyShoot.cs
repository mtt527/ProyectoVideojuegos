using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour
{
    public GameObject playerTarget;
    public GameObject bullet;
    public GameObject cannon;

    PlayerDetector playerC;

    public float repetition;

    public int timer = 1;

    bool isInAction = false;
    bool newShoot = true;
    
    // Use this for initialization
    void Start()
    {
        playerC = GetComponent<PlayerDetector>();
        playerTarget = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerC.isClose && !isInAction)
        {
            isInAction = true;
            StartCoroutine(ShootTime());
        }
        if (isInAction)
        {
            transform.LookAt(playerTarget.transform.position);
            if (newShoot)
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
        yield return new WaitForSeconds(timer);
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