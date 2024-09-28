using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimals : MonoBehaviour
{
    private int speedAnimal = 10;
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speedAnimal);
    }
}
