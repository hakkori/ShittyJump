using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	public BoxCollider2D bc;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.transform.position.y > transform.position.y){
			bc.isTrigger = false;
			bc.size = new Vector2 (2.25f, 2.25f);
		}
	}

}
