using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
	public Transform t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("a")) {
			Quaternion q = t.rotation;
			Vector3 qEA = q.eulerAngles;
			float y = qEA.y;
			y += 1.0f;
			t.localRotation = Quaternion.Euler (new Vector3 (qEA.x, y, qEA.z));

		}
		if (Input.GetKey ("d")) {
			Quaternion q = t.rotation;
			Vector3 qEA = q.eulerAngles;
			float y = qEA.y;
			y -= 1.0f;
			t.localRotation = Quaternion.Euler (new Vector3 (qEA.x, y, qEA.z));
		}
	}
}
