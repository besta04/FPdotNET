using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	int score = 0;
	static int highScore = 0;
	
	private float startTime;
	bool flagNabrak = false;
	
	// Use this for initialization
	void Start () 
	{
		score = 0;
		highScore = PlayerPrefs.GetInt ("highscore");
	}
	
	public void addScore()
	{
		if( flagNabrak == false )
			score = score + 1;
	}
	
	public int getScore()
	{
		return this.score;
	}
	
	public void Nabrak()
	{
		flagNabrak = true;
		Debug.Log ("masuk");
	}
	
	// Update is called once per frame
	void Update () 
	{
		guiText.text = "SCORE: " + score;
		if (flagNabrak == true) {
			score = getScore();
			if(score > highScore){
				highScore = score;
				PlayerPrefs.SetInt("highscore" , score);
				PlayerPrefs.Save();
			}
			guiText.text = "SCORE: " + score + "\nHIGHSCORE: " + highScore;
		}
	}
}
