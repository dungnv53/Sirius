using UnityEngine;
using System.Collections;

public class MoverRight : MonoBehaviour {
	float speed = 1.0f;
	float speedDown = 0.0f; // 0.2f; TODO disable right loop
	// Use this for initialization
	void Start () {
//		rigidbody2D.velocity = -transform.right  * speed - transform.up * speedDown;
	}
	
	// Update is called once per frame
	void Update () {
//		if (PlayerController.Death ()) {
//			rigidbody2D.velocity = -transform.right * 0.0f;
//		} else {
//			rigidbody2D.velocity = -transform.right  * speed - transform.up * speedDown;
//		}
	}
}
