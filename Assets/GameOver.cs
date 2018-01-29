using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public static int score;
    public Text scoretext;
    public Text transmit1text;
    public Text transmit2text;
    public Text transmit3text;

    // Use this for initialization
    void Awake()
    {
       score = Player.score;
    }

    // Update is called once per frame
    void Update()
    {
       scoretext.text = score + "";

        if (Input.anyKey)
        {
            score = 0;
            SceneManager.LoadScene("scene1");
          }

    }
}
