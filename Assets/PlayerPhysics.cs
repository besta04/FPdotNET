using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {
	
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

		// Here the position of the player is clamped into the boundaries
		transform.position = (new Vector3 (Mathf.Clamp (transform.position.x, leftBorder, rightBorder), transform.position.y, transform.position.z));

		// buat fungsi kalo nabrak, panggil method spawn
	}
}
