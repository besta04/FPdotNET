using UnityEngine;
using System.Collections;

public class ObstacleBlackController : ObstacleController {

	private Score score;

	// Use this for initialization
	void Start () {
		score = FindObjectOfType (typeof(Score)) as Score;
		generator = FindObjectOfType (typeof(GenerateBlack)) as GenerateBlack;
		speed = GameManager.getScrollSpeed ();
	}


	protected override void Clean(){
		score.addScore();
		// increase speed at score=5 and per 10 score
		if( score.getScore()==5 || score.getScore()%10==0  )
		{
			(generator as GenerateBlack).Faster();
		}
		Destroy(this.gameObject);
	}
}
