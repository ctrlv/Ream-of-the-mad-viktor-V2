using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed= 5f;

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        //input
        Input.GetAxisRaw("horizontal");
    }

    void FixedUpdate(){


    }
}
