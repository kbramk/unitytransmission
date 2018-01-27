using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{

    private GameObject mPlayer;
    private GameObject target;
    private float speed;
    private var direction;

    private

    // Use this for initialization
    void Start()
    {
        mPlayer = GameObject.FindGameObjectWithTag("Player");//.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Transmitter.transmit1 == true)
        {
            target = mPlayer;
            speed = 2.5f;
            print("transmit1truexd");
        }
        if (Transmitter.transmit2 == true)
        {
            print("transmit2truexd");
        }
        if (Transmitter.transmit3 == true)
        {
            print("transmit3truexd");
        }

        direction = (target.transform.position - this.transform.position);
        this.transform.position = Vector3.Distance (target.transform.position - this.transform.position) * speed;

    }
}
