﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private GameCamera camera;
	// untuk akses atribut player, didrag aja lewat unitynya
	private GameObject player;

	// speed scrolling speed
	private static float scrollSpeed;

	private float startTime;

	public static float getScrollSpeed()
	{
		return scrollSpeed;
	}
	private bool flagTabrak;
	private bool messageRetry;
	// Use this for initialization
	void Start ()
	{
		SpawnPlayer ();
	}

	// Update is called once per frame
	void Update()
	{
		if (flagTabrak != true) {
			Debug.Log (getScore().ToString());
		}
		else {
			messageRetry = true;
		}
	}


	int getScore()
	{
		float timeCount;
		timeCount = Time.time - startTime;
		return (int)timeCount;
	}


	void SpawnPlayer()
	{
		// instantiate player di sini, dipanggil ketika start
		scrollSpeed = 0.2f;
		camera = GetComponent<GameCamera> ();
		// call fungsi instantiate
		startTime = Time.time;
	}

	public void Nabrak()
	{
		flagTabrak = true;
	}

	void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 60;
		if(messageRetry == true){
			if (
				GUI.Button(
				// Center in X, 1/3 of the height in Y
				new Rect(
				Screen.width / 2 - (buttonWidth / 2),
				(1 * Screen.height / 3) - (buttonHeight / 2),
				buttonWidth,
				buttonHeight
				),
				"Retry!"
				)
				)
			{
				// Reload the level
				Application.LoadLevel("Scene");
			}
			
			if (
				GUI.Button(
				// Center in X, 2/3 of the height in Y
				new Rect(
				Screen.width / 2 - (buttonWidth / 2),
				(2 * Screen.height / 3) - (buttonHeight / 2),
				buttonWidth,
				buttonHeight
				),
				"Back to menu"
				)
				)
			{
				// Reload the level
				Application.LoadLevel("HomeScreen");
			}
		}
	}
}
