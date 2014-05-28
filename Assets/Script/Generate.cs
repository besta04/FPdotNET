using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject capsule;

	public float posY = -6.236147f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateObstacle()
	{
		Instantiate (capsule, new Vector3 (1.586072f, posY, 11), Quaternion.identity);
		posY -= 10;
	}
}
