using UnityEngine;
using System.Collections;

public class TurretController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 bodyposition = (GameObject.Find ("entPlayer").transform.position + new Vector3 (0f, 0f, -0.4663933f));
		transform.position = bodyposition;
		if Input.g
	}
}
