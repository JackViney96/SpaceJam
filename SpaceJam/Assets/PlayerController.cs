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
	}
}
