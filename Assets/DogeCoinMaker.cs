using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeCoinMaker : MonoBehaviour
{
    public GameObject prototype;
    private GameObject clone;


    /*int GenerateRandomRange()
    {
        return Random.Range(walls.width, 5);
    }*/

    void Update()
    {
        if (clone == null)
        {
            clone = Spawn();
        }
    }

    GameObject Spawn()
    {
        return Instantiate(prototype,
                        new Vector3(Random.Range(walls.lowerx, walls.upperx),
                            Random.Range(walls.lowery, walls.uppery),
                            0),
                        Quaternion.identity);
    }
}
