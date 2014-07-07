using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 100f; //We define the speed the controller moves at
	public float deadzone = 0.1f;
	// Update is called once per frame
	void Update () {
		Movement ();
	}
	void Movement() {
		if(Input.GetAxisRaw("X axis")> deadzone || Input.GetAxisRaw("X axis") < -deadzone)
		{
			rigidbody.AddForce(Vector3.right * ((speed * -Input.GetAxisRaw("X axis")) * Time.deltaTime));	
		}
		
		if(Input.GetAxisRaw("Y axis")> deadzone|| Input.GetAxisRaw("Y axis") < -deadzone)
		{
			rigidbody.AddForce(Vector3.up * ((speed * Input.GetAxisRaw("Y axis")) * Time.deltaTime));
		}
		/*
		if (Input.GetAxis("Vertical") == 1)
		{
			rigidbody.AddForce(Vector3.up * (speed * Time.deltaTime));	
		}
		if (Input.GetAxis("Vertical") == -1)
		{
			rigidbody.AddForce(-Vector3.up * (speed * Time.deltaTime));	
		}
		if (Input.GetAxis("Horizontal") == 1) {
			rigidbody.AddForce(Vector3.right * (speed * Time.deltaTime));	
		}
		if (Input.GetAxis("Horizontal") == -1) {
			rigidbody.AddForce(-Vector3.right * (speed * Time.deltaTime));
		}

		/* //Physical Forces are applied to the controller's rigidbody to move it.
		if (Input.GetKey (KeyCode.W)) {
			rigidbody.AddForce(Vector3.up * (speed * Time.deltaTime));	
		}
		if (Input.GetKey (KeyCode.S)) {
			rigidbody.AddForce(-Vector3.up * (speed * Time.deltaTime));
		}
		if (Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce(Vector3.right * (speed * Time.deltaTime));	
		}
		if (Input.GetKey (KeyCode.A)) {
			rigidbody.AddForce(-Vector3.right * (speed * Time.deltaTime));
		}
		*/
	}
}
