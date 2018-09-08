using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour {

	// BE SURE TO OPTIMIZE BY PUTTING NECESSARY CONSTANTS IN CONSTANTS CLASS
	public int index;
	private GameObject[] elements;
	private GameObject consts;
	private Color RED = Color.red;
	private Color GREEN = Color.green;
	private GameObject platform;
	private string the_platform;


	void Start () {
		consts = GameObject.Find("Constants");
		the_platform = "Straight_Boy";
		platform = GameObject.Find(the_platform);
		foreach (Renderer r in platform.GetComponentsInChildren<Renderer>()) {
			r.material.SetColor("_Color", RED);
		}
	}

	void Update () {
		Constants refScript = consts.GetComponent<Constants>();

		if (refScript.CURRENT_SELECTED_BLOCK_INDEX == index) {
			foreach (Renderer r in platform.GetComponentsInChildren<Renderer>()) {
				r.material.SetColor("_Color", GREEN);
			}
			gameObject.GetComponent<Movement>().enabled = true;
			gameObject.GetComponent<ShapeShift>().enabled = true;

		} else {
			//foreach (Transform element in platform) {
			foreach (Renderer r in platform.GetComponentsInChildren<Renderer>()) {
				//rend = element.GetComponent<Renderer>();
				r.material.SetColor("_Color", RED);
			}
			gameObject.GetComponent<Movement>().enabled = false;
			gameObject.GetComponent<ShapeShift>().enabled = false;
		
		}
	
	}


}
