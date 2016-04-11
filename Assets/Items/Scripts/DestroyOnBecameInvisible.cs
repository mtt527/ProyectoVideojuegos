using UnityEngine;
using System.Collections;

public class DestroyOnBecameInvisible : MonoBehaviour {

    public GameObject cameraObject;
    CameraController camCon;
    public Camera firstCamera;
    public Camera mainCamera;
    float diferenceDifference;
    // Use this for initialization
    void Start () {
        
        cameraObject = GameObject.FindGameObjectWithTag("CameraController");
        camCon = cameraObject.GetComponent<CameraController>();
    }
	
	// Update is called once per frame
	void Update () {
	if(!camCon.activecam)
        {
            diferenceDifference = Vector3.Distance(transform.position, mainCamera.transform.position);
            if (diferenceDifference > 100)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            diferenceDifference = Vector3.Distance(transform.position, firstCamera.transform.position);
            if (diferenceDifference > 100)
            {
                Destroy(gameObject);
            }
        }
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
