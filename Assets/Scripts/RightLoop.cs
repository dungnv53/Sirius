using UnityEngine;
using System.Collections;

public class RightLoop : MonoBehaviour {
	int numGachPanels = 23;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		//Debug.Log ("Triggered : " + collider.name);
//		if (collider.tag == "Gach" || collider.tag == "Ochua") {
//			float widthOfGachObject = ((BoxCollider2D)collider).size.x;
//			Vector3 pos = collider.transform.position;
//			pos.x -= widthOfGachObject * numGachPanels ;
//			collider.transform.position = pos;
//		}
	}
}
