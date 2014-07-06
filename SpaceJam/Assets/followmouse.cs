using UnityEngine;
using System.Collections;

public class followmouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;
		transform.position = mousePos;
	}
}
