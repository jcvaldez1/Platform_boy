using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// CONSTANTS FOR TUNING
	private float speed = 10;
	Rigidbody2D rbody;
	Vector2 movement_vector;
	private GameObject platform;
	private string platform_name;
	//SCRIPT START
	void Start () {
		platform_name = "Straight_Boy";
		platform = GameObject.Find (platform_name);
		rbody = gameObject.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		movement_vector = new Vector2( Input.GetAxis("Horizontal") * speed * Time.deltaTime ,  Input.GetAxis("Vertical") * speed * Time.deltaTime);
		rbody.MovePosition(rbody.position + movement_vector);
	}
}
