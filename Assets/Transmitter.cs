using System;
using System.Collections.Generic;
using UnityEngine;

public class Transmitter : MonoBehaviour
{
    public List<GameObject> myTransmissions;

    string transmission;
    public string Transmission
    {
        get
        {
            return transmission;
        }
        private set
        {
            transmission = value;
            if (TransmissionChanged == null) { return; }
            TransmissionChanged.Invoke(this, new EventArgs());
        }
    }
    public event EventHandler TransmissionChanged;

    public GameObject transmissions;

    public static bool transmit1 = true;
    public static bool transmit2 = false;
    public static bool transmit3 = false;

    public float timer = 0;
    private float targettime = 10;
    private Player mPlayer;

    // Use this for initialization
    void Start()
    {
        mPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        myTransmissions[0].SetActive(true);
        myTransmissions[1].SetActive(false);
        myTransmissions[2].SetActive(false);
        mPlayer.transmit1text.text = "1 Active. Press 2 or 3.";

    }

    // Update is called once per frame
    void Update()
    {
             timer += Time.deltaTime;
            if (timer >= targettime) {
            print ("playsound");
            transmissions.GetComponent<AudioSource>().Play();
            timer = 0;
        }

        if ((Input.GetKeyDown("1")) || (Input.GetKeyDown(KeyCode.Keypad1)))
        {
            timer = 0;
            transmit1 = true;
            transmit2 = false;
            transmit3 = false;
            myTransmissions[0].SetActive(true);
            myTransmissions[1].SetActive(false);
            myTransmissions[2].SetActive(false);
            print("1 was pressed");
            mPlayer.transmit1text.text = "1 Active. Press 2 or 3.";
            mPlayer.transmit2text.text = "";
            mPlayer.transmit3text.text = "";
            Transmission = "1";
            //wait 1 second or some kind of code to disable the other 2 keys for a second
        }

        if ((Input.GetKeyDown("2")) || (Input.GetKeyDown(KeyCode.Keypad2)))
        {
            timer = 0;
            transmit1 = false;
            transmit2 = true;
            transmit3 = false;
            myTransmissions[0].SetActive(false);
            myTransmissions[1].SetActive(true);
            myTransmissions[2].SetActive(false);
            print("2 was pressed");
            mPlayer.transmit1text.text = "";
            mPlayer.transmit2text.text = "2 Active. Press 1 or 3.";
            mPlayer.transmit3text.text = "";
            Transmission = "2";
            //wait 1 second
        }

        if ((Input.GetKeyDown("3")) || (Input.GetKeyDown(KeyCode.Keypad3)))
        {
            timer = 0;
            transmit1 = false;
            transmit2 = false;
            transmit3 = true;
            myTransmissions[0].SetActive(false);
            myTransmissions[1].SetActive(false);
            myTransmissions[2].SetActive(true);
            print("3 was pressed");
            mPlayer.transmit1text.text = "";
            mPlayer.transmit2text.text = "";
            mPlayer.transmit3text.text = "3 Active. Press 1 or 2.";
            Transmission = "3";
            //wait 1 second
        }
    }
}
