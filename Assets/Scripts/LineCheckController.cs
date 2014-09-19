using UnityEngine;
using System.Collections;

public class LineCheckController : MonoBehaviour {
	int numLine =  12;

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log ("Triggered : " + collider.name);
		if (collider.tag == "Gach" || collider.tag == "Ochua" || collider.tag == "GachLeft" || collider.tag == "OchuaLeft") {
			float heightOfGachObject = ((BoxCollider2D)collider).size.y;
			Vector3 pos = collider.transform.position;
			pos.y += heightOfGachObject * numLine ;
			collider.transform.position = pos;
		}
	}

}
