﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    // Use this for initialization
    public float speed;
    private Rigidbody rb;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }
    void Update () {
		
	}
    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0,moveVertical);
        rb.AddForce(movement*speed);
	}
}