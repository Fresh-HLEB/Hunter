using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] animals;
    private int index;
    private Vector3 position;
    private void Start()
    {
        InvokeRepeating("Spawn", 2, 3);
    }

    void Spawn()
    {
        position = new Vector3(Random.Range(11, -50), 0, Random.Range(220, 100));
        index = Random.Range(0, animals.Length);
        Instantiate(animals[index], position, animals[index].transform.rotation);
    }
}
