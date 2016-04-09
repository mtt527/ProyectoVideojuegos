using UnityEngine;
using System.Collections;

public class EnemyRotation : MonoBehaviour {
    public float rotationSpeed = 25f;
    //Rigidbody rb;
    public GameObject turret;
    PlayerDetection playerC;
    // Use this for initialization
    void Start () {
        //turret = GameObject.FindGameObjectWithTag("Turret");
        //rb = turret.GetComponent<Rigidbody>();
        playerC = GetComponent<PlayerDetection>();
    }
	
	// Update is called once per frame
	void Update () {
        if(!playerC.isDetected)
        {
            turret.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else
        {
            turret.transform.rotation = transform.rotation;
        }
    }
    //void FixedUpdate()
    //{
    //    Vector3 movement = new Vector3(0f,1f, 0f);

    //    rb.AddRelativeForce(movement * rotationSpeed, ForceMode.Force);
    //}
}
