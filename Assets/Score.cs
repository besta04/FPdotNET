using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static int score = 0;
	static int highScore = 0;

	private float startTime;
	bool flagNabrak = false;

	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;
		highScore = PlayerPrefs.GetInt ("highscore");
	}

	int getScore()
	{
		float timeCount;
		timeCount = Time.time - startTime;
		score = (int)timeCount;
		return (int)timeCount;
	}

	public void Nabrak()
	{
		flagNabrak = true;
		Debug.Log ("masuk");
	}

	// Update is called once per frame
	void Update () 
	{
		if (flagNabrak != true) {
			guiText.text = "" + this.getScore ();
			if(score > highScore)
			{
				guiText.text = "" + this.getScore ();
			}
		}
		else {
			if(score > highScore)
			{
				PlayerPrefs.SetInt("highscore" , score);
				PlayerPrefs.Save();
			}
			guiText.text = "SCORE: " + score + "\nHIGHSCORE: " + PlayerPrefs.GetInt ("highscore");
		}
	}
}
