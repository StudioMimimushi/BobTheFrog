using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	Text latestScore;
	void Start () {
	
		latestScore = GetComponent<Text> ();


		if (ScoreScript.score > PlayerPrefs.GetInt("Score1")){
			PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
			PlayerPrefs.SetInt("Score2", PlayerPrefs.GetInt("Score1"));
			PlayerPrefs.SetInt("Score1", ScoreScript.score);
		}
		if (ScoreScript.score > PlayerPrefs.GetInt("Score2") && ScoreScript.score < PlayerPrefs.GetInt("Score1")){
			PlayerPrefs.SetInt("Score3", PlayerPrefs.GetInt("Score2"));
			PlayerPrefs.SetInt("Score2", ScoreScript.score);
		}
		if (ScoreScript.score > PlayerPrefs.GetInt("Score3") && ScoreScript.score < PlayerPrefs.GetInt("Score2")){
			PlayerPrefs.SetInt("Score3", ScoreScript.score);
		}

	}
	
	// Update is called once per frame
	void Update () {

		latestScore.text = "Score: " + ScoreScript.score;
	
	}


	public void retryButton() {
		ScoreScript.score = 0;
		Debug.Log ("retryButton");		
		Application.LoadLevel ("GameScene");
		
	}
	public void returnToTitle() {
		ScoreScript.score = 0;
		Debug.Log ("returnToTitle");
		
		Application.LoadLevel ("TitleScene");
		
	}
	public void leaderboardScene() {
		Debug.Log ("leaderboardScene");
		
		Application.LoadLevel ("LeaderboardScene");
		
	}
}
