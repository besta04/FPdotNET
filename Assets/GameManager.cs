﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// untuk akses atribut player, didrag aja lewat unitynya
	private GameObject player;
	private Texture play;
	private Texture back;

	// speed scrolling speed
	private static float scrollSpeed;

	private float startTime;

	private bool flagTabrak;
	private bool messageRetry;
	private int score , highScore;

	// Use this for initialization
	void Start ()
	{
		play = (Texture)Resources.Load("play");
		back = (Texture)Resources.Load("back");
		SpawnObstacle ();
	}

	// Update is called once per frame
	void Update()
	{
		if (flagTabrak == true) {
			messageRetry = true;
		}
	}

	public static float getScrollSpeed()
	{
		return scrollSpeed;
	}



	void SpawnObstacle()
	{
		// instantiate player di sini, dipanggil ketika start
		scrollSpeed = 0.15f;
		//camera = GetComponent<GameCamera> ();
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
				play
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
				back
				)
				)
			{
				// Reload the level
				Application.LoadLevel("HomeScreen");
			}
		}
	}
}
