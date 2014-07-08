using UnityEngine;
using System.Collections;

	public class PlayerRotation : MonoBehaviour 
{
	public float deadzone = 0.1f;
	public float turnforce = 0.1f;
	void FixedUpdate () 
	{
		if (Input.GetAxisRaw("4th axis")> deadzone|| Input.GetAxisRaw("4th axis") < -deadzone)
		{
			rigidbody.AddTorque(Vector3.forward * (turnforce * Input.GetAxisRaw("4th axis")));
		}
		
		if(Input.GetAxisRaw("5th axis")> deadzone|| Input.GetAxisRaw("5th axis") < -deadzone)
		{
			rigidbody.AddTorque(Vector3.forward * (turnforce * Input.GetAxisRaw("5th axis")));
		}
		Vector3 thumbStick = new Vector3(Input.GetAxisRaw("4th axis"), Input.GetAxisRaw("5th axis"), 0);
		//UpdateAngularVelocity (Quaternion.Angle(transform.rotation, transform.rotation));
		transform.rotation = Quaternion.Inverse(Quaternion.FromToRotation(Vector3.right, thumbStick));
		if (thumbStick[1] != 0 && thumbStick[2] != 0) 
		{
			Quaternion current_rotation = transform.rotation;
		}
	}

	void UpdateAngularVelocity(Quaternion desired)
	{
		var z = Vector3.Cross(transform.forward, desired * Vector3.forward);
		var y = Vector3.Cross(transform.up, desired * Vector3.up);
		
		var thetaZ = Mathf.Asin(z.magnitude);
		var thetaY = Mathf.Asin(y.magnitude);
		
		var dt = Time.fixedDeltaTime;
		var wZ = z.normalized * (thetaZ / dt);
		var wY = y.normalized * (thetaY / dt);
		
		var q = transform.rotation * rigidbody.inertiaTensorRotation;
		var T = q * Vector3.Scale(rigidbody.inertiaTensor, Quaternion.Inverse(q) * (wZ + wY));
		
		// too wobbly
		//rigidbody.AddTorque(T, ForceMode.VelocityChange);
		
		// stable, but still laggy
		rigidbody.angularVelocity = T;
		rigidbody.maxAngularVelocity = T.magnitude;
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