using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startdogecoin : MonoBehaviour
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

    void OnCollisionEnter(Collision col)
    {
        print("collide");
        if (col.gameObject.name == "Player")
        {
            SceneManager.LoadScene("scene1");
        }
    }
        // Update is called once per frame
        void Update()
    {
        //scoretext.text = score + "";
        float outofbounddown = -5f;
        if (gameObject.transform.position.y <= outofbounddown)
        {
            SceneManager.LoadScene("scene1");
        }
        float outofboundup = 5f;
        if (gameObject.transform.position.y >= outofboundup)
        {
            SceneManager.LoadScene("scene1");
        }
        float outofboundleft = -10f;
        if (gameObject.transform.position.x <= outofboundleft)
        {
            SceneManager.LoadScene("scene1");
        }
        float outofboundright = 10f;
        if (gameObject.transform.position.x >= outofboundright)
        {
            SceneManager.LoadScene("scene1");
        }
    }
}
