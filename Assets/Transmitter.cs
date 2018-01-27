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

    public static bool transmit1 = true;
    public static bool transmit2 = false;
    public static bool transmit3 = false;

    private Player mPlayer;

    // Use this for initialization
    void Start()
    {
        mPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            transmit1 = true;
            transmit2 = false;
            transmit3 = false;
            myTransmissions[0].SetActive(true);
            myTransmissions[1].SetActive(false);
            myTransmissions[2].SetActive(false);
            print("1 was pressed");
            mPlayer.transmit1text.text = "Active";
            mPlayer.transmit2text.text = "";
            mPlayer.transmit3text.text = "";
            Transmission = "1";
            //wait 1 second or some kind of code to disable the other 2 keys for a second
        }

        if (Input.GetKeyDown("2"))
        {
            transmit1 = false;
            transmit2 = true;
            transmit3 = false;
            print("2 was pressed");
            mPlayer.transmit1text.text = "";
            mPlayer.transmit2text.text = "Active";
            mPlayer.transmit3text.text = "";
            Transmission = "2";
            //wait 1 second
        }

        if (Input.GetKeyDown("3"))
        {
            transmit1 = false;
            transmit2 = false;
            transmit3 = true;
            print("3 was pressed");
            mPlayer.transmit1text.text = "";
            mPlayer.transmit2text.text = "";
            mPlayer.transmit3text.text = "Active";
            Transmission = "3";
            //wait 1 second
        }
    }
}
