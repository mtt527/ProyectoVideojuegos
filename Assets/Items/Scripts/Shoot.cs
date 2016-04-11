using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public GameObject cannon;
    public Camera firstCamera;
    
    public GameObject cameraObject;
    CameraController camCon;

    // Use this for initialization
    void Start () {
        cameraObject = GameObject.FindGameObjectWithTag("CameraController");
        camCon = cameraObject.GetComponent<CameraController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootingDelay());
        }

    }
    public void Shooting()
    {
        if (camCon.activecam)
        {
            Ray ray = firstCamera.ScreenPointToRay(Input.mousePosition);
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = cannon.transform.position;
            newBullet.transform.rotation = cannon.transform.rotation;
            newBullet.transform.LookAt(ray.direction * 1000);
        }
        else
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = cannon.transform.position;
            newBullet.transform.rotation = cannon.transform.rotation;
        }
       
    }

    IEnumerator ShootingDelay()
    {
        yield return new WaitForSeconds(0.35f);
        Shooting();
    }
}
