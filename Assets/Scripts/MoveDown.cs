using UnityEngine;
using System.Collections;

public class MoveDown : MonoBehaviour {
	float speed = 1.0f;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = -transform.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
