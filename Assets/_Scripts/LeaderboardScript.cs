using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeaderboardScript : MonoBehaviour {

	GameObject firstScoreObj;
	GameObject secondScoreObj;
	GameObject thirdScoreObj;
	string firstScore;
	string secondScore;
	string thirdScore;
	// Use this for initialization
	void Start () {
		firstScoreObj = GameObject.Find ("FirstScore");
		secondScoreObj = GameObject.Find ("SecondScore");
		thirdScoreObj = GameObject.Find ("ThirdScore");
	}
	
	// Update is called once per frame
	void Update () {
		firstScore = "" + PlayerPrefs.GetInt ("Score1").ToString();
		secondScore = "" + PlayerPrefs.GetInt ("Score2").ToString();
		thirdScore = "" + PlayerPrefs.GetInt ("Score3").ToString();

		firstScoreObj.GetComponent<Text>().text = firstScore;
		secondScoreObj.GetComponent<Text>().text = secondScore;
		thirdScoreObj.GetComponent<Text>().text = thirdScore;
//		thirdScore.text = "" + PlayerPrefs.GetInt ("Score3");

	}

	public void returnToScene() {
		LevelManager.changeToPreviousLvl ();
		
	}
}
