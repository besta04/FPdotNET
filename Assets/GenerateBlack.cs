using UnityEngine;
using System.Collections;

public class GenerateBlack : Generate {

	private bool flagTabrak;

	// Use this for initialization
	void Start () {
		// initial speed
		speed = 2f;
		// spawn obstacle periodically
		Invoke("CreateObstacle", speed);
		// y position spawn
		posY = Camera.main.transform.position.y + Camera.main.orthographicSize;
	}
	
	// Update is called once per frame
	void Update () {
		if (flagTabrak == true) {
			CancelInvoke("CreateObstacle");
		}
	}
	
	public void Faster()
	{
		// dont get faster if game end
		if( flagTabrak==true ) return;
		
		// speedup
		speed -= 0.3f;
		if( speed<maxSpeed ) speed=maxSpeed;
		Debug.Log (speed);
	}

	public void Nabrak()
	{
		//	Debug.Log("ketabrak");
		flagTabrak = true;
	}

	void CreateObstacle()
	{
		// kiri kanannya
		float rand = Random.Range(-2.5f,2.5f);
		// ukurannya
		float randObst = Random.Range (3f, 5.5f);
		var instantiated = Instantiate (capsule, new Vector3 (rand, posY, 11), Quaternion.identity) as GameObject;
		instantiated.transform.localScale = new Vector3(randObst,randObst,11);
		
		CancelInvoke("CreateObstacle");
		Invoke("CreateObstacle", speed);
	}
}
