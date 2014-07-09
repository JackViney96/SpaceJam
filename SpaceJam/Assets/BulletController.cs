using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public float BulletSpeed = 1.0f;
	Quaternion bulletRotation = Quaternion.identity;
	// Use this for initialization
	void Start () {
		Quaternion bulletRotation = (GameObject.Find ("entPlayer_turret").transform.rotation);
		return bulletRotation;
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion.RotateTowards (transform.rotation, bulletRotation, 1); 
	}
}
