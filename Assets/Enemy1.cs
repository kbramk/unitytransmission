using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {

    private 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Transmitter.transmit1 == true) {
            print("transmit1truexd");
        }
        if (Transmitter.transmit2 == true) {
            print("transmit2truexd");
        }
        if (Transmitter.transmit3 == true) {
            print("transmit3truexd");
        }
    }
}
