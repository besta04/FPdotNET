﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GameManager))]
public class ObstacleWhiteController : MonoBehaviour {
	
	private Score score;
	private Generate generator;
	void Start ()
	{
		score = FindObjectOfType (typeof(Score)) as Score;
		generator = FindObjectOfType (typeof(Generate)) as Generate;
	}
	
	// Update is called once per frame
	void Update () {
		//	Debug.Log (GameManager.getScrollSpeed ());
		Vector2 move = new Vector2 (0,GameManager.getScrollSpeed()) ;
		transform.Translate(-move/10f);
		
		var distance = (transform.position - Camera.main.transform.position).z;
		var topBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, distance)).y + (renderer.bounds.size.y/2);
		
		//optional
		var bottomBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distance)).y - (renderer.bounds.size.y / 2);
		
		if( transform.position.y < bottomBorder )
		{	
			Destroy(this.gameObject);
		}
	}
}