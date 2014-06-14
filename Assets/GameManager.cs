using UnityEngine;
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
}
