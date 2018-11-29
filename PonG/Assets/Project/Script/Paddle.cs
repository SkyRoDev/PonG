﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float speed = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float verticalMovement = Input.GetAxis("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2(
			0,
			verticalMovement * speed
			);
	}
}
