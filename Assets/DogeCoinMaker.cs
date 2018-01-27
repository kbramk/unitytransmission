using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogeCoinMaker : MonoBehaviour
{
    public GameObject prototype;
    private GameObject clone;

    int GenerateRandomRange()
    {
        return Random.Range(-4, 4);
    }

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
                        new Vector3(GenerateRandomRange(),
                            GenerateRandomRange(),
                            0),
                        Quaternion.identity);
    }
}
