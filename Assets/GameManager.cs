using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private GameCamera camera;
	// untuk akses atribut player, didrag aja lewat unitynya
	private GameObject player;

	// speed scrolling speed
	private static float scrollSpeed;

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

	}
	
	// Update is called once per frame
	void SpawnPlayer()
	{
		// instantiate player di sini, dipanggil ketika start
	}
}
