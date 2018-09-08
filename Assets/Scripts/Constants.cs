using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour {

	// THIS SCRIPT SHOULD ONLY CONTAIN GLOBALLY REFERENCEABLE VALUES OPEN FOR TWEAKING
	public int CURRENT_SELECTED_BLOCK_INDEX = -1; //INIT -1

	void Update () {
		for ( int i = 0; i < 10; ++i )
		{
			if ( Input.GetKeyDown( "" + i ) )
			{
				CURRENT_SELECTED_BLOCK_INDEX = i;
			}
		}
	}
}
