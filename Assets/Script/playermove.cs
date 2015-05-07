using UnityEngine;
using System.Collections;

public class playermove : MonoBehaviour {

	Vector3 position;
	bool jump;
	float speedmove=3;
	float speedjump=200;
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
            audio.Play();
			position= transform.position+Vector3.left;
			this.gameObject.transform.position = Vector3.MoveTowards (transform.position, position, speedmove * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D)) {
            audio.Play();
			position= transform.position+Vector3.right;
			this.gameObject.transform.position = Vector3.MoveTowards (transform.position, position, speedmove * Time.deltaTime);
		}
		if (!jump) {
			if (Input.GetKey (KeyCode.Space)) {
                audio.Play();
				GetComponent<Rigidbody> ().velocity = Vector3.zero;
				GetComponent<Rigidbody> ().AddForce (Vector3.up * speedjump);		
			}
		}
	}

	void OnCollisionEnter(Collision other){
		//Debug.Log ("Tersentuh");
        if (other.gameObject.tag == "Point")
            other.gameObject.audio.Play();
	}

	void OnCollisionExit(Collision other){
		//Debug.Log ("Terlepas");
        if (other.gameObject.tag == "Point")
            other.gameObject.audio.Stop();
	}
}
