using UnityEngine;
using System.Collections;

	public class PlayerRotation : MonoBehaviour 
{
	public Transform target;
	public float force = 0.1f;
	void Update () 
	{
		Vector3 targetDelta = target.position - transform.position;
		
		//get the angle between transform.forward and target delta
		float angleDiff = Vector3.Angle(transform.forward, targetDelta);
		
		// get its cross product, which is the axis of rotation to
		// get from one vector to the other
		Vector3 cross = Vector3.Cross(transform.forward, targetDelta);
		
		// apply torque along that axis according to the magnitude of the angle.
		rigidbody.AddTorque(cross * angleDiff * force);
	}
}
/*
using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		/*Vector3 mousePos = Input.mousePosition;
		transform.LookAt(mousePos);
		//
		//rotation
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		//transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
		rigidbody.AddRelativeTorque(new Vector3(0, 0, angle));

	}
}
*/
/*
using UnityEngine;
using System.Collections;

// @robotduck 2011
// set the object's rigidbody angular drag to a high value, like 10

public class PlayerRotation : MonoBehaviour {
	
	public Transform target;
	public float force = 0.1f;
	
	
	// Update is called once per frame
	void Update () {
		
		Vector3 targetDelta = target.position - transform.position;
		
		//get the angle between transform.forward and target delta
		float angleDiff = Vector3.Angle(transform.forward, targetDelta);
		
		// get its cross product, which is the axis of rotation to
		// get from one vector to the other
		Vector3 cross = Vector3.Cross(transform.forward, targetDelta);
		
		// apply torque along that axis according to the magnitude of the angle.
		rigidbody.AddTorque(cross * angleDiff * force);
		
		
	}
}
*/