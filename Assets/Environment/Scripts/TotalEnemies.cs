using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalEnemies : MonoBehaviour {
    public Text total;
   public int totalEnemies = 20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        total.GetComponent<Text>().text = totalEnemies.ToString() + "/20";
        if(totalEnemies <= 0)
        {
            Application.LoadLevel("menu");
        }
	}
     public void OnDestrction()
    {
        totalEnemies--;
    }
}
