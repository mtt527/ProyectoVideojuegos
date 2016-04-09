using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HpController : MonoBehaviour {
    public GameObject playerTarget;
    PlayerController pc;

    public RawImage resist1;
    public RawImage resist2;
    public RawImage resist3;
    public RawImage resist4;
    public RawImage resist5;
    public RawImage resist6;
    public RawImage resist7;
    public RawImage resist8;
    public RawImage resist9;
    public RawImage resist10;
    // Use this for initialization
    void Start () {
        playerTarget = GameObject.FindGameObjectWithTag("Player");
        pc = playerTarget.GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
	if(pc.hp == 10)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = true;
            resist5.GetComponent<RawImage>().enabled = true;
            resist6.GetComponent<RawImage>().enabled = true;
            resist7.GetComponent<RawImage>().enabled = true;
            resist8.GetComponent<RawImage>().enabled = true;
            resist9.GetComponent<RawImage>().enabled = true;
            resist10.GetComponent<RawImage>().enabled = true;
        }
        if (pc.hp == 9)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = true;
            resist5.GetComponent<RawImage>().enabled = true;
            resist6.GetComponent<RawImage>().enabled = true;
            resist7.GetComponent<RawImage>().enabled = true;
            resist8.GetComponent<RawImage>().enabled = true;
            resist9.GetComponent<RawImage>().enabled = true;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 8)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = true;
            resist5.GetComponent<RawImage>().enabled = true;
            resist6.GetComponent<RawImage>().enabled = true;
            resist7.GetComponent<RawImage>().enabled = true;
            resist8.GetComponent<RawImage>().enabled = true;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 7)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = true;
            resist5.GetComponent<RawImage>().enabled = true;
            resist6.GetComponent<RawImage>().enabled = true;
            resist7.GetComponent<RawImage>().enabled = true;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 6)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = true;
            resist5.GetComponent<RawImage>().enabled = true;
            resist6.GetComponent<RawImage>().enabled = true;
            resist7.GetComponent<RawImage>().enabled = false;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 5)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = true;
            resist5.GetComponent<RawImage>().enabled = true;
            resist6.GetComponent<RawImage>().enabled = false;
            resist7.GetComponent<RawImage>().enabled = false;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 4)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = true;
            resist5.GetComponent<RawImage>().enabled = false;
            resist6.GetComponent<RawImage>().enabled = false;
            resist7.GetComponent<RawImage>().enabled = false;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 3)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = true;
            resist4.GetComponent<RawImage>().enabled = false;
            resist5.GetComponent<RawImage>().enabled = false;
            resist6.GetComponent<RawImage>().enabled = false;
            resist7.GetComponent<RawImage>().enabled = false;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 2)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = true;
            resist3.GetComponent<RawImage>().enabled = false;
            resist4.GetComponent<RawImage>().enabled = false;
            resist5.GetComponent<RawImage>().enabled = false;
            resist6.GetComponent<RawImage>().enabled = false;
            resist7.GetComponent<RawImage>().enabled = false;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp == 1)
        {
            resist1.GetComponent<RawImage>().enabled = true;
            resist2.GetComponent<RawImage>().enabled = false;
            resist3.GetComponent<RawImage>().enabled = false;
            resist4.GetComponent<RawImage>().enabled = false;
            resist5.GetComponent<RawImage>().enabled = false;
            resist6.GetComponent<RawImage>().enabled = false;
            resist7.GetComponent<RawImage>().enabled = false;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
        if (pc.hp <= 0)
        {
            resist1.GetComponent<RawImage>().enabled = false;
            resist2.GetComponent<RawImage>().enabled = false;
            resist3.GetComponent<RawImage>().enabled = false;
            resist4.GetComponent<RawImage>().enabled = false;
            resist5.GetComponent<RawImage>().enabled = false;
            resist6.GetComponent<RawImage>().enabled = false;
            resist7.GetComponent<RawImage>().enabled = false;
            resist8.GetComponent<RawImage>().enabled = false;
            resist9.GetComponent<RawImage>().enabled = false;
            resist10.GetComponent<RawImage>().enabled = false;
        }
    }
}
