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
	// character kemiringans
	private int angle;

	private bool die;

	public Texture2D textureToDisplay;

	private PlayerPhysics plPhysics;

	public Generate generate;

	public GameManager gameManager;

	public Score score;

	public Sprite dieBerry;
	private SpriteRenderer spriteRenderer;
	private Animator animator;

	void Start ()
	{
		animator = transform.GetComponentInChildren<Animator> ();
		die = false;
		plPhysics = GetComponent<PlayerPhysics> ();
		generate = FindObjectOfType (typeof(GenerateBlack)) as GenerateBlack;
		gameManager = FindObjectOfType (typeof(GameManager)) as GameManager;
		score = FindObjectOfType (typeof(Score)) as Score;
		midX = Screen.width / 2;
		speed = 0;
		acceleration = 0.016f;
		maxSpeed = 0.3f;
		angle = 0;
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void Update()
	{



		// input mouse
		if( die==false && (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))	 )
		{
			float x = Input.mousePosition.x;

			// kiri
			if(x < midX)
			{
				speed -= acceleration;
				if( angle<30 ) angle++;
			}
			// kanan
			else
			{
				speed += acceleration;
				if( angle>-30 ) angle--;
			}
		}
		else
		{
			speed = 0;
			if( angle<0 ) angle++;
			else if( angle>0 ) angle--;
		}
		plPhysics.transform.rotation = Quaternion.Euler(new Vector3(0,0,angle));

		// max speed check
		if( speed > maxSpeed )
		{
			speed = maxSpeed;
		}
		else if( speed < -maxSpeed )
		{
			speed = -maxSpeed;
		}
		if( die==true ) {
			animator.SetTrigger("Mati");
		}

		// move
		plPhysics.MoveAmount (new Vector2(speed,0f));

	}

	void OnCollisionEnter2D(){
		die = true;
		Debug.Log("nabrak");
		(generate as GenerateBlack).Nabrak ();
		gameManager.Nabrak ();
		score.Nabrak ();
	}
}
