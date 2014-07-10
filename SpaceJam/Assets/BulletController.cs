using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public Transform prefab;
	void Example() {
		int i = 0;
		while (i < 10) {
			Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity) as Transform;
			i++;
		}
	}
}