using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {

	public bool IS_COLLIDED;
	// Use this for initialization
	void Start () {
		IS_COLLIDED = false;
	}
		
	void OnTriggerEnter2D(Collider2D other){
		IS_COLLIDED = true;
	}

	void OnTriggerExit2D(Collider2D other){
		IS_COLLIDED = false;
	}
}
