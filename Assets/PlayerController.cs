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

	private bool messagePopup;

	public Texture2D textureToDisplay;

	private PlayerPhysics plPhysics;

	public Generate gen;

	void Start ()
	{
		plPhysics = GetComponent<PlayerPhysics> ();
		midX = Screen.width / 2;
		speed = 0;
		acceleration = 0.1f;
		maxSpeed = 0.3f;
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
		}
		else
		{
			// reset speed
			speed = 0;
		}

		// max speed check
		if( speed > maxSpeed )
		{
			speed = maxSpeed;
		}
		else if( speed < -maxSpeed )
		{
			speed = -maxSpeed;
		}

		// move
		plPhysics.MoveAmount (new Vector2(speed,0));

		/*
		// input touchscreen
		if(Input.touchCount > 0)
		{
			// touch count checking
			for(var i = 0; i < Input.touchCount; ++i)
			{
				// get the last input touch
				Touch touch = Input.GetTouch(i);
				if(touch.phase == TouchPhase.Began)
				{
					// kiri
					if(touch.position.x < midX)
					{
						speed -= acceleration;
					}
					// kanan
					else
					{
						speed += acceleration;
					}
				}
			}
		}
		else
		{
			// reset speed
			speed = 0;
		}

		// max speed check
		if( speed > maxSpeed )
		{
			speed = maxSpeed;
		}
		else if( speed < -maxSpeed )
		{
			speed = -maxSpeed;
		}
		
		// move
		plPhysics.MoveAmount (new Vector2(speed,0));
		*/
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		//Destroy (this.gameObject);
		messagePopup = true;
	}

	void OnGUI()
	{
		if (messagePopup == true) 
		{
			GUI.Label(new Rect (Screen.width/4,Screen.height/2,200,20), "You have been killed !");
			StopSpawning();
		}
	}

	//fungsi untuk supaya berenti spawn - masih belum jalan
	void StopSpawning()
	{
		GetComponent<Generate> ().CancelInvoke ("CreateObstacle");
		//gen.CancelInvoke ("CreateObstacle");
	}
}
