using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

	private Rigidbody2D rb;
	public float movement_speed = 10.0f;
	private float direction = 1.0f; 
	public float jumpSpeed;


	// COLLIDERS ARE HERE // WOULD BE NICE TO FIND A WAY TO COLLATE THIS
	private GameObject collider_right_top;
	private GameObject collider_right_bottom;
	private GameObject collider_left_top;
	private GameObject collider_left_bottom;
	private string COLLIDER_RIGHT_TOP_NAME;
	private string COLLIDER_RIGHT_BOTTOM_NAME;
	private string COLLIDER_LEFT_TOP_NAME;
	private string COLLIDER_LEFT_BOTTOM_NAME;
	private Rotation_Checker COLLIDER_RIGHT_TOP;
	private Rotation_Checker COLLIDER_RIGHT_BOTTOM;
	private Rotation_Checker COLLIDER_LEFT_TOP;
	private Rotation_Checker COLLIDER_LEFT_BOTTOM;

	void Start () {

		COLLIDER_RIGHT_TOP_NAME = "Checker_Boy_Right_0";
		COLLIDER_RIGHT_BOTTOM_NAME = "Checker_Boy_Right_1";
		COLLIDER_LEFT_TOP_NAME = "Checker_Boy_Left_0";
		COLLIDER_LEFT_BOTTOM_NAME = "Checker_Boy_Left_1";

		collider_right_top = GameObject.Find (COLLIDER_RIGHT_TOP_NAME);
		collider_right_bottom = GameObject.Find (COLLIDER_RIGHT_BOTTOM_NAME);
		collider_left_top = GameObject.Find (COLLIDER_LEFT_TOP_NAME);
		collider_left_bottom = GameObject.Find (COLLIDER_LEFT_BOTTOM_NAME);

		COLLIDER_RIGHT_TOP = collider_right_top.GetComponent<Rotation_Checker> ();
		COLLIDER_RIGHT_BOTTOM = collider_right_bottom.GetComponent<Rotation_Checker> ();
		COLLIDER_LEFT_TOP = collider_left_top.GetComponent<Rotation_Checker> ();
		COLLIDER_LEFT_BOTTOM = collider_left_bottom.GetComponent<Rotation_Checker> ();

		jumpSpeed = 4.2f;
	}
	
	void Update () {
		
		if (COLLIDER_RIGHT_BOTTOM.IS_COLLIDED && !COLLIDER_RIGHT_TOP.IS_COLLIDED) {	
			transform.Translate (Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
		} else if (COLLIDER_LEFT_BOTTOM.IS_COLLIDED && !COLLIDER_LEFT_TOP.IS_COLLIDED) {
			transform.Translate (Vector3.up * jumpSpeed * Time.deltaTime, Space.World);
		} 
		transform.Translate(new Vector2( 2.0f , 0.0f ) * Time.deltaTime * direction, Space.Self);

	}
}
