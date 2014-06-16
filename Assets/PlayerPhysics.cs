using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {

	private float playerPosY;

	public void Start()
	{
		playerPosY = -3.720471f;
	}

	public void MoveAmount(Vector2 moveAmount)
	{
		// move player 
		transform.Translate(moveAmount);

		// player size
		Vector3 playerSize = renderer.bounds.size;
		
		// Here is the definition of the boundary in world point
		var distance = (transform.position - Camera.main.transform.position).z;
		
		var leftBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distance)).x + (playerSize.x/2);
		var rightBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distance)).x - (playerSize.x/2);
		var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance)).y + playerSize.y/2;
		var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0,1,distance)).y - playerSize.y/2;


		// Here the position of the player is clamped into the boundaries
		transform.position = (new Vector3 (Mathf.Clamp (transform.position.x, leftBorder, rightBorder), 
		                                   Mathf.Clamp(playerPosY, topBorder, bottomBorder),
		                                   transform.position.z));

		// buat fungsi kalo nabrak, panggil method spawn
	}
}
