﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeCoin : MonoBehaviour {

    //coinmaker = GameObject.FindGameObjectWithTag("CoinMaker");
    private bool collected = false;

    void OnCollisionEnter(Collision col)
    {
        print("collide");
        if (col.gameObject.name == "Player")
        {
            print("score+1");
            Player.score = Player.score + 1;
            //DogeCoinMaker.makecoin = true;
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    
}
