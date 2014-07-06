using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public Transform target;
	
	void Update ()
	{
		transform.LookAt(target);
	}
}
