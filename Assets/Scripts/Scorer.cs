using UnityEngine;
using System.Collections;

public class Scorer : MonoBehaviour {

	int score = 0;
	int highScore;

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt("highscore", 0);

		SetScore(score, highScore);
	}

	public void AddScore(){
		score++;

		if(score > highScore){
			highScore = score;
		}

		SetScore(score, highScore);
	}

	private void SetScore(int score, int highScore){
		guiText.text = "Score: " + score + "\nHighScore: " + highScore;
	}

	void OnDestroy(){
		PlayerPrefs.SetInt("highscore", highScore);
	}
	
}
