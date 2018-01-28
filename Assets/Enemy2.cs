using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
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
            target = mPlayer;
            speed = 3.5f;
            var direction = Vector3.Normalize(target.transform.position - this.transform.position);
            this.transform.Translate(direction * speed * Time.deltaTime);
        }
        if (Transmitter.transmit2 == true)
        {
            target = DogeCoinMaker.CoinObject;
            speed = 2f;
            var direction = Vector3.Normalize(target.transform.position - this.transform.position);
            this.transform.Translate(direction * speed * Time.deltaTime);
        }
        if (Transmitter.transmit3 == true)
        {
            target = mPlayer;
            speed = 0.5f;
            var direction = Vector3.Normalize(target.transform.position - this.transform.position);
            this.transform.Translate(direction * speed * Time.deltaTime);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        print("collide");
        if (col.gameObject.name == "Player")
        {
            Player.health = Player.health - 1;
            print(Player.health);
        }
    }
}
