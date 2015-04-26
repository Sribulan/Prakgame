using UnityEngine;
using System.Collections;

public class lompat : MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody> ().velocity = Vector3.zero;
			GetComponent<Rigidbody> ().AddForce (Vector3.up * 100);		
		}
	}
}
