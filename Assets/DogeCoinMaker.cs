using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeCoinMaker : MonoBehaviour {

    public bool makecoin = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (makecoin == true)
        {
           // Instantiate(DogeCoin, new Vector3(Random.Range(-9, 10), Random.Range(-5, 5) , 0), Quaternion.identity);
            makecoin = false;
        }
    }



}
