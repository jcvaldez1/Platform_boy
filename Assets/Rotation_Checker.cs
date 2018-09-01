﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Checker : MonoBehaviour {

	public bool IS_COLLIDED;
	// Use this for initialization
	void Start () {
		IS_COLLIDED = false;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (!other.gameObject.CompareTag ("Sensor")) {
			IS_COLLIDED = true;
		}

	}

	void OnTriggerExit2D(Collider2D other){
		if (!other.gameObject.CompareTag ("Sensor")) {
			IS_COLLIDED = false;
		}
	}
}
