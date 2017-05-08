using UnityEngine;
using System.Collections;

public class PlatformGenerater : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("platformSpawn", 2, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//your prefab link
	public GameObject platform;
	//spawntime of platform
	public float spawnTime;
	//yUp max y on y axe for random spawn, yDown for min on y axe (maybe 3, 0 for test).
	public float xMin, xMax;

	//funktion for spawn
	void platformSpawn () {
		//random point on y axe for spawn
		float x = Random.Range (xMin, xMax);
		//make vector3 for spawn position (i set z to zero)
		Vector3 pos = new Vector3 (x,  transform.position.y, 0);
		//set platform in the world (transform.rotation as from main gameObject ("platformController")
		Instantiate (platform, pos, transform.rotation);
	}

}
