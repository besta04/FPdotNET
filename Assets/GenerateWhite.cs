using UnityEngine;
using System.Collections;

public class GenerateWhite : Generate {

	// Use this for initialization
	void Start () {
		// initial speed
		speed = 2f;
		// spawn obstacle periodically
		InvokeRepeating ("CreateObstacleWhite", speed, speed);
		// y position spawn
		posY = Camera.main.transform.position.y + Camera.main.orthographicSize;
	}

	void Update () {
	}

	void CreateObstacleWhite()
	{
		// kiri kanannya
		float rand = Random.Range(-2.5f,2.5f);
		// ukurannya
		float randObst = Random.Range (3f, 10f);
		var instantiated = Instantiate (capsule, new Vector3 (rand, posY, 12), Quaternion.identity) as GameObject;
		instantiated.transform.localScale = new Vector3(randObst,randObst,12);
	}
}
