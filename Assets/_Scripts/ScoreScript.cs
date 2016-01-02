using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static int score;

	
	//public static int lastScoreNumber;
	//GameObject finalScoreObj;
	Text currentScore;
	//Text lastScore;

	// Use this for initialization
	void Awake () {
	//	finalScoreObj = GameObject.Find ("FinalScoreText");
		currentScore = GetComponent<Text> ();
	//	lastScore = finalScoreObj.GetComponent<Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentScore.text = "Score: " + score;
	//	lastScoreNumber = score;
	//	lastScore.text = "Score: " + lastScoreNumber;

		//lastScoreNumber = score;
		//lastScore.text = "Score: " + lastScoreNumber;

	}
	//public void finalScore()
	//{


		
	//}

}
