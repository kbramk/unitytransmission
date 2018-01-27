using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{

    private GameObject mPlayer;
    private GameObject target;
    private float speed = 1;

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
            print("transmit1truexd");
        }
        if (Transmitter.transmit2 == true)
        {
            target = mPlayer;
            speed = 1f;
            var direction = -(target.transform.position - this.transform.position);
            this.transform.Translate(direction * speed * Time.deltaTime);
            print("transmit2truexd");
        }
        if (Transmitter.transmit3 == true)
        {
            target = mPlayer;
            speed = 2f;
            var direction = (target.transform.position - this.transform.position);
            this.transform.Translate(direction * speed * Time.deltaTime);
            
            print("transmit3truexd");
        }


        //this.transform.position = Vector3.Distance (target.transform.position, this.transform.position) * speed *Time.deltaTime;

    }
}
