using UnityEngine;
using System.Collections;

public class Move: MonoBehaviour {
	
	Vector3 position;
	bool jump;
	float speedmove=50;
	float speedjump=300;
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			position= transform.position+Vector3.left;
			this.gameObject.transform.position = Vector3.MoveTowards (transform.position, position, speedmove * Time.deltaTime);
		}
		
		if (Input.GetKeyDown (KeyCode.D)) {
			position= transform.position+Vector3.right;
			this.gameObject.transform.position = Vector3.MoveTowards (transform.position, position, speedmove * Time.deltaTime);
		}
		if (!jump) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				GetComponent<Rigidbody> ().velocity = Vector3.zero;
				GetComponent<Rigidbody> ().AddForce (Vector3.up * speedjump);		
			}
		}
	}
	
	void OnCollisionEnter(Collision other){
		//jump = false;;
		Debug.Log ("Tersentuh");
	}
	
	void OnCollisionExit(Collision other){
		//jump = true;
		Debug.Log ("Terlepas");
	}
}
