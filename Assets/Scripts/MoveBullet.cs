using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private int speedBullet = 100;
    void Update()
    {
        transform.Translate(Vector3.right*Time.deltaTime*speedBullet);
    }
}
