using UnityEngine;
using System.Collections;

public class playerjump : MonoBehaviour {
	float Lompat;
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
		audio.Play();
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 100);		
		}
	}
}
