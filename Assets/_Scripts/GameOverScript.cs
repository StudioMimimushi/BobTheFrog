using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	LevelManager.setLastLevel(Application.loadedLevelName);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void retryButton() {
		Debug.Log ("retryButton");		
		Application.LoadLevel ("GameScene");
		
	}
	public void returnToTitle() {
		Debug.Log ("returnToTitle");
		
		Application.LoadLevel ("TitleScene");
		
	}
	public void leaderboardScene() {
		Debug.Log ("learderboardScene");
		
		Application.LoadLevel ("LeaderboardScene");
		
	}
	public void creditScene() {
		Debug.Log ("creditScene");
		
		Application.LoadLevel ("CreditScene");
		
	}
}
