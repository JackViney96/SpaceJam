using UnityEngine;
using System.Collections;

	public class PlayerRotation : MonoBehaviour 
{
	public float deadzone = 0.1f;
	public float turnforce = 5.0f;
	void FixedUpdate () 
	{
		Vector3 ThumbStick = new Vector3(Input.GetAxis("4th axis"), Input.GetAxis("5th axis"), 0);
		Quaternion RotationGoal = Quaternion.Inverse (Quaternion.FromToRotation (Vector3.right, ThumbStick));
		if (Input.GetAxis ("5th axis") > deadzone || Input.GetAxis ("5th axis") < -deadzone || Input.GetAxis ("4th axis") > deadzone || Input.GetAxis ("4th axis") < -deadzone) 
		{

			transform.rotation = Quaternion.RotateTowards(transform.rotation, RotationGoal, turnforce);

		}
	}
}
