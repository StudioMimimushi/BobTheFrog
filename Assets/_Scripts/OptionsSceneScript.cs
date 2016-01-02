using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelManager.setLastLevel(Application.loadedLevelName);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void returnToScene() {
		Debug.Log ("returnToTitle");		
		Application.LoadLevel ("TitleScene");
	
	}

	public void MoveToCreditScene() {
		Debug.Log ("MoveToCreditScene");
		Application.LoadLevel ("CreditScene");
	}


	public void MoveToLeaderScene() {
		Debug.Log ("MoveToLeaderboardScene");
		Application.LoadLevel ("LeaderboardScene");
	}

	public void resetScore(){	
		PlayerPrefs.DeleteAll ();
	}

}
