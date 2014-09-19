using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	float speed = 0.0f; // 1.0f HOT FIX
	float speedDown = 0.0f; //0.2f; Disable speed down
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.right  * speed - transform.up * speedDown;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerController.Death ()) {
			rigidbody2D.velocity = transform.right * 0.0f;
		} else {
			rigidbody2D.velocity = transform.right  * speed - transform.up * speedDown;
		}
	}
}
