using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GameManager))]
public class ObstacleController : MonoBehaviour {

	protected Generate generator;
	protected float speed;

	void Start (){


	}
	
	// Update is called once per frame
	void Update () {
	//	Debug.Log (GameManager.getScrollSpeed ());
		Vector2 move = new Vector2 (0,speed) ;
		transform.Translate(-move);
		
		var distance = (transform.position - Camera.main.transform.position).z;
		var topBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, distance)).y + (renderer.bounds.size.y/2);

		var bottomBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distance)).y - (renderer.bounds.size.y / 2);

		if( transform.position.y < bottomBorder )
		{	
			Clean ();
		}
	}

	protected virtual void Clean(){

	}
}
