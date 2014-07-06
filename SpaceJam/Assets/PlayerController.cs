using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 100;

	// Update is called once per frame
	void Update () {
		Movement ();
	}
	void Movement() {
		if (Input.GetKey (KeyCode.W)) {
			rigidbody.AddForce(Vector3.up * (speed * Time.deltaTime));	
			//transform.eulerAngles = new Vector2(0, 0); //Sprite Faces Right
		}
		if (Input.GetKey (KeyCode.S)) {
			rigidbody.AddForce(-Vector3.up * (speed * Time.deltaTime));
			//transform.eulerAngles = new Vector2(0, 180); //Sprite Faces Left
		}
		if (Input.GetKey (KeyCode.D)) {
			rigidbody.AddForce(Vector3.right * (speed * Time.deltaTime));
			//transform.Translate (Vector2.up * 4f * Time.deltaTime);	
		}
		if (Input.GetKey (KeyCode.A)) {
			rigidbody.AddForce(-Vector3.right * (speed * Time.deltaTime));
		}
	}
}
