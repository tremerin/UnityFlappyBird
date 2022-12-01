using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    public float worldSpeed = 2;
    public float x;

    void Update()
    {
        x+= worldSpeed * Time.deltaTime;
        transform.position = new Vector3(-x, 0, 0)  ;  
    }
}
