using UnityEngine;
using System.Collections;

public class PlayerDetector : MonoBehaviour {
    public float maxDifferencetoWalk;
    public float maxDifferencetoAttack;
    float COOLDOWN = 5f;
    float difference;

    public GameObject playerTarget;
   
    public bool isDetected;
    public bool isClose;
    [SerializeField]
    bool isCooldown;

    // Use this for initialization
    void Start()
    {
        playerTarget = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(!isCooldown)
        {
            difference = Vector3.Distance(transform.position, playerTarget.transform.position);
        }
       
        if ((difference <= maxDifferencetoAttack))
        {   
            isClose = true;
            isDetected = false;
        }
        else if ((difference <= maxDifferencetoWalk) && (difference > maxDifferencetoAttack) && !isClose)
        {
            isDetected = true;
        }
       
    }
    public void ChangeDetection()
    {
        isClose = false;
        isCooldown = true;
        DetectionCoolDown();
    }

    IEnumerator DetectionCoolDown()
    {
        yield return new WaitForSeconds(COOLDOWN);
        isCooldown = false;
        yield return new WaitForEndOfFrame();

    }
}
