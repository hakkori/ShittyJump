using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rb;
	public float speed;
	public GameObject platform;
	public GameObject lastCreatedPlatform;
	public Transform laserPoint;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.gameObject.transform.position = new Vector3 (0,transform.position.y,-10);
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (rb.velocity.x, speed);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (speed , rb.velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (-speed , rb.velocity.y);
		} 


		// Debug.Log (MathHelper.degreeBetween2Points(transform.position , v3));




		if (Input.GetMouseButtonDown(0)) {
			var v3 = Input.mousePosition;
			v3.z = 10.0f;
			v3 = Camera.main.ScreenToWorldPoint(v3);
		//	float degree = MathHelper.degreeBetween2Points (transform.position, v3);
			if (lastCreatedPlatform != null) {
				lastCreatedPlatform = (GameObject) Instantiate (platform, lastCreatedPlatform.transform.position + new Vector3 (0, 4), Quaternion.Euler (0, 0, 0));
			} else {
				lastCreatedPlatform = (GameObject) Instantiate (platform, v3,Quaternion.Euler (0, 0, 0));
			}

		//	rb.AddForce ( new Vector2 (speed * Mathf.Cos (degree * Mathf.Deg2Rad), speed * Mathf.Sin (degree * Mathf.Deg2Rad)));
		}

	}




}
