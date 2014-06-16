﻿using UnityEngine;
using System.Collections;

public class GenerateWhite : MonoBehaviour {
	
	public GameObject capsule;
	private bool flagTabrak;
	private float posY;
	private float speed;
	private const float maxSpeed = 0.4f;
	
	// Use this for initialization
	void Start () {
		// initial speed
		speed = 2f;
		// spawn obstacle periodically
		InvokeRepeating ("CreateObstacle", speed, speed);
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
		speed -= 0.3f;
		if( speed<maxSpeed ) speed=maxSpeed;
		Debug.Log (speed);
	}
	
	void CreateObstacle()
	{
		// kiri kanannya
		float rand = Random.Range(-2.5f,2.5f);
		// ukurannya
		float randObst = Random.Range (3f, 10f);
		var instantiated = Instantiate (capsule, new Vector3 (rand, posY, 12), Quaternion.identity) as GameObject;
		instantiated.transform.localScale = new Vector3(randObst,randObst,12);
		
		CancelInvoke("CreateObstacle");
		InvokeRepeating ("CreateObstacle", speed, speed);
	}
	
	public void Nabrak()
	{
		//	Debug.Log("ketabrak");
		flagTabrak = true;
	}
}