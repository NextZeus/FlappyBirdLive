﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdLive : MonoBehaviour {
    private float upForce = 200f;
	private bool isDead = false;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
        if(!isDead){
            if(Input.GetMouseButtonDown(0)){
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
    }
}
