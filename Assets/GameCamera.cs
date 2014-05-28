using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

	public Transform target;

	// Update is called once per frame
	void Update ()
	{
		// yang ini buat mindahin posisi kamera agar ngikutin player terus, cuma 4.160129f seharusnya diglobal variabel
		//transform.position = new Vector3(0, target.position.y - 4.160129f, transform.position.z);
	}
}
