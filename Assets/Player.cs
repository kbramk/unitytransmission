using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public bool playertarget;
    public static int health;
    public static int score;
    public Text scoretext;
    public Text transmit1text;
    public Text transmit2text;
    public Text transmit3text;

    // Use this for initialization
    void Awake () {
        health = 10;
        score = 0;
        scoretext.text = score + "";
        transmit1text.text = "Active";
        transmit2text.text = "";
        transmit3text.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        scoretext.text = score + "";

        if (Player.health <= 0){
            SceneManager.LoadScene("scene1");
            //Destroy(this.gameObject);
        }
        //if (Player.transform.position >= 100) {
        //    SceneManager.LoadScene("scene1");
        //}

    }
}
