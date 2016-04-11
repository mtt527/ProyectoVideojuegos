using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	public GameObject Fpcam;
	public GameObject Tpcam;
	public GameObject Joystick;

	public GameObject knife;
	public GameObject bomb;
	public GameObject shoot;

	public bool fpc;
	// Use this for initialization
	void Start () {

		fpc = true;
	}

	public void FirstPersonCam () {

		if (fpc) {
			
			Fpcam.SetActive (true);
			Tpcam.SetActive (false);
			Joystick.SetActive (false);

			knife.SetActive (true);
			bomb.SetActive (true);
			shoot.SetActive (true);

			fpc = !fpc;
		} 

		else {

			Tpcam.SetActive (true);
			Fpcam.SetActive (false);
			Joystick.SetActive (true);

			knife.SetActive (false);
			bomb.SetActive (false);
			shoot.SetActive (false);

			fpc = !fpc;
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
