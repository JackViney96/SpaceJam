﻿ using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		/*Vector3 mousePos = Input.mousePosition;
		transform.LookAt(mousePos);
		*/
		//rotation
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


	}
}
