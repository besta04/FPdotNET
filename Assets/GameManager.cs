using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private GameCamera camera;
	// untuk akses atribut player, didrag aja lewat unitynya
	private GameObject player;

	// speed scrolling speed
	private static float scrollSpeed;

	float startTime , timeCount;

	public static float getScrollSpeed()
	{
		return scrollSpeed;
	}

	// Use this for initialization
	void Start ()
	{
		scrollSpeed = 0.2f;
		camera = GetComponent<GameCamera> ();
		// call fungsi instantiate
		startTime = Time.time;
	}

	// Update is called once per frame
	void Update()
	{
		timeCount = Time.time - startTime;
		Debug.Log (((int)timeCount).ToString());
	}

	void SpawnPlayer()
	{
		// instantiate player di sini, dipanggil ketika start
	}
}
