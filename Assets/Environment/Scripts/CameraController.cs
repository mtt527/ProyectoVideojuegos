using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject maincamera;
    public GameObject firstcamera;
    public GameObject playertarget;
    Vector3 offset1;
    Vector3 offset2;
    public bool activecam = false;
    // Use this for initialization
    void Start () {
        firstcamera = GameObject.Find("FirstPersonCamera");
        firstcamera.SetActive(false);
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
        playertarget = GameObject.FindGameObjectWithTag("Player");
        offset1 = maincamera.transform.position - playertarget.transform.position;
        offset2 = firstcamera.transform.position - playertarget.transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.F))
        {
            activecam = !activecam;

        }
        if (activecam)
        {
            firstcamera.SetActive(true);
            maincamera.SetActive(false);
            
        }
        else
        {
            firstcamera.SetActive(false);
            maincamera.SetActive(true);
            
        }
        if (playertarget == null)
        {
            playertarget = GameObject.FindGameObjectWithTag("Player");
        }
        Vector3 desiredPosition1 = playertarget.transform.position + offset1;
        maincamera.transform.position = desiredPosition1;

        Vector3 desiredPosition2 = playertarget.transform.position + offset2;
        firstcamera.transform.position = desiredPosition2;

    }
}
