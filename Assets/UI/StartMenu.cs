using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	public GameObject StartButton;
	public GameObject InfoButton;

	public GameObject About;
	public GameObject goBack;
	// Use this for initialization
	void Start () {
	
		About.SetActive (false);
		goBack.SetActive (false);
	}

	public void LoadLevel (string levelname){
		
		Application.LoadLevel (levelname);
	}

	public void ShowInfo () {

		StartButton.SetActive (false);
		InfoButton.SetActive (false);

		About.SetActive (true);
		goBack.SetActive (true);
	}

	public void Back () {

		StartButton.SetActive (true);
		InfoButton.SetActive (true);

		About.SetActive (false);
		goBack.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
