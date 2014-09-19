using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	float speed = 1.0f;
	float speedDown = 0.0f; //0.2f;
	bool isRunleft = false;
	bool didJump = false;
	static bool isDeath = false;
	public AudioSource[] audios;

	// Use this for initialization
	void Start () {
		if (isRunleft) {
			rigidbody2D.velocity = -transform.right  * speed - transform.up * speedDown;
		} else {
			rigidbody2D.velocity = transform.right  * speed - transform.up * speedDown;
		}
	}
	
	static public bool Death(){
		return false; // isDeath; TODO tempory live forever
	}

	// Update is called once per frame
	void Update () {
		if (isDeath) {
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				isDeath = false;
				Score.ResetPoint();
				Application.LoadLevel (Application.loadedLevel);	
			}
		} else {
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
//				isRunleft = !isRunleft;
				didJump = true;
			}
		}

	}

	void FixedUpdate(){

		if(didJump){
			transform.Translate(Vector3.up * 15 * Time.deltaTime);
			didJump = false;
		}
		if (!isDeath) {
			if (isRunleft) {
				rigidbody2D.velocity = -transform.right  * speed - transform.up * speedDown;
			} else {
				rigidbody2D.velocity = transform.right  * speed - transform.up * speedDown;
			}
		} else {
			rigidbody2D.velocity = -transform.up * 8.0f;
		}

	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Triggered : " + collider.name);
		if (collider.tag == "Gach" || collider.tag == "GachLeft" || collider.tag == "Death") {
			audios[1].audio.Play();
			isDeath = true;
		}
		if (!isDeath) {
			Vector3 pos = collider.transform.position;
			pos.z = -4;
			transform.position = pos;
			audios[0].audio.Play();
			Score.AddPoint();
		}
		//	deathCooldown = 0.5f;
	
	}

}
