using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour {

    public bool playertarget;
    public static int health = 10;
    public static int score;
    public Text scoretext;
    public Text transmit1text;
    public Text transmit2text;
    public Text transmit3text;

    // Use this for initialization
    void Start () {
        scoretext.text = score + "";
        transmit1text.text = "Active";
        transmit2text.text = "";
        transmit3text.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        scoretext.text = score + "";

        if (Player.health <= 0){
            Destroy(this.gameObject);
        }
    }
}
