using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerPhysics))]
public class PlayerController : MonoBehaviour {

	// player speed
	public float speed;
	// default acceleration value
	public float acceleration;
	// speed limit
	public float maxSpeed;

	// screen middle x
	private float midX;

	private PlayerPhysics plPhysics;

	void Start ()
	{
		plPhysics = GetComponent<PlayerPhysics> ();
		midX = Screen.width / 2;
		speed = 0;
		acceleration = 0.01f;
		maxSpeed = 0.2f;
	}

	void Update()
	{
		// input mouse
		if( Input.GetMouseButton(0) || Input.GetMouseButtonDown(0) )
		{
			float x = Input.mousePosition.x;

			// kiri
			if(x < midX)
			{
				speed -= acceleration;
			}
			// kanan
			else
			{
				speed += acceleration;
			}
			//nextSpeed = Input.GetAxisRaw ("Horizontal") * speed;
		}
		else
		{
			// reset speed
			speed = 0;
		}

		// max speed check
		if( speed > maxSpeed ) speed = maxSpeed;
		else if( speed < -maxSpeed ) speed = -maxSpeed;

		// move
		plPhysics.MoveAmount (new Vector2(speed,0));
	}
}
