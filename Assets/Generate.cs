using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject capsule;
	private bool flagTabrak;
	private float posY;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
		posY = 6.236147f;
	}
	
	// Update is called once per frame
	void Update () {
		if (flagTabrak == true) {
			CancelInvoke ("CreateObstacle");
		}
	}

	void CreateObstacle()
	{
		float rand = Random.Range(-2.5f,2.5f);
		var instantiated = Instantiate (capsule, new Vector3 (rand, posY, 11), Quaternion.identity) as GameObject;
		instantiated.transform.localScale = new Vector3(1,1,11);
	}

	public void Nabrak()
	{
		Debug.Log("ketabrak");
		flagTabrak = true;
	}
}
