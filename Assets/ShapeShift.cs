using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeShift : MonoBehaviour {

	private float waittime = 0.1f;
	private string this_name = "Straight_Boy";
	private bool pos_init_flag = false;
	private GameObject collider_0;
	private GameObject collider_1;
	private string COLLIDER_0_NAME;
	private string COLLIDER_1_NAME;
	private Rotation_Checker COLLIDER_0;
	private Rotation_Checker COLLIDER_1;

	void Start () {

		COLLIDER_0_NAME = "Checker_Boy_0";
		COLLIDER_1_NAME = "Checker_Boy_1";
		collider_0 = GameObject.Find (COLLIDER_0_NAME);
		collider_1 = GameObject.Find (COLLIDER_1_NAME);
		COLLIDER_0 = collider_0.GetComponent<Rotation_Checker> ();
		COLLIDER_1 = collider_1.GetComponent<Rotation_Checker> ();
	}

	void Update () {
		
		if (Input.GetKeyDown ("space") && !COLLIDER_0.IS_COLLIDED  && !COLLIDER_1.IS_COLLIDED   ) {
			Invoke("Flippo" , waittime);
		}
	}

	void Flippo () {

		// WOULD BE NICE TO PUT A CHECKER HERE TO SEE IF OBJECT COULD ROTATE OR NOT.
		transform.Rotate (0, 0, 90, Space.Self);

	}

}
