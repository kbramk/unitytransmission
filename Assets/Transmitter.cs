using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmitter : MonoBehaviour {

    public bool transmit1 = true;
    public bool transmit2 = false;
    public bool transmit3 = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("1"))
        {
            transmit1 = true;
            transmit2 = false;
            transmit3 = false;
            print("1 was pressed");
            //wait 1 second or some kind of code to disable the other 2 keys for a second
        }

        if (Input.GetKeyDown("2"))
        {
            transmit1 = false;
            transmit2 = true;
            transmit3 = false;
            print("2 was pressed");
            //wait 1 second
        }

        if (Input.GetKeyDown("3"))
        {
            transmit1 = false;
            transmit2 = false;
            transmit3 = true;
            print("3 was pressed");
            //wait 1 second
        }
    }



}
