using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeCoin : MonoBehaviour
{
    
    void OnCollisionEnter(Collision col)
    {
        print("collide");
        if (col.gameObject.name == "Player")
        {
            print("score+1");
            Player.score = Player.score + 1;
            print(GetComponent<AudioSource>());
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }

}
