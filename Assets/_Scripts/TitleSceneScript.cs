using UnityEngine;
using System.Collections;

public class TitleSceneScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
		LevelManager.setLastLevel(Application.loadedLevelName);
	}
	
	// Update is called once per frame
	void Update () {
		//SoundManagerScript.Instance.volumeBGM (Application.);
	}

	//Move to game scene
	public void MoveToGameScene() {
		LevelManager.setLastLevel ("TitleScene");
		Application.LoadLevel ("GameScene");
	}

	//Move to options scene
	public void MoveToOptionsScene() {
		LevelManager.setLastLevel ("TitleScene");
		Application.LoadLevel ("OptionsScene");
	}
}
