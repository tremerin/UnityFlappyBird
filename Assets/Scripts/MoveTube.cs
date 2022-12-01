using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTube : MonoBehaviour
{
    public Rigidbody2D rB;
    public float speed;
    
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
