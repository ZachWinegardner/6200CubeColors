﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    Rigidbody rb; 
    public float speed = 10f;
    public float power; 

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // print("jump"); 
            rb.AddForce(Vector3.up * power);
        }

    }
}
