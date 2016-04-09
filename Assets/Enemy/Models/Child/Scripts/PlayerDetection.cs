using UnityEngine;
using System.Collections;

public class PlayerDetection : MonoBehaviour {
    public float maxDifference;
    public GameObject playerTarget;
    float difference;
    public bool isDetected = false;

    // Use this for initialization
    void Start () {
        playerTarget = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        difference = Vector3.Distance(transform.position, playerTarget.transform.position);
        if(difference <= maxDifference)
        {
            isDetected = true;
        }
    }
    public void ChangeDetection()
    {
        isDetected = false;
    }
}
