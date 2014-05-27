using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private GameCamera camera;
	// untuk akses atribut player, didrag aja lewat unitynya
	public GameObject player;

	// Use this for initialization
	void Start ()
	{
		camera = GetComponent<GameCamera> ();
		// call fungsi instantiate
	}
	
	// Update is called once per frame
	void SpawnPlayer()
	{
		// instantiate player di sini, dipanggil ketika start
	}
}
