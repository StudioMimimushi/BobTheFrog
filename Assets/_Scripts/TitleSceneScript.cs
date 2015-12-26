using UnityEngine;
using System.Collections;

public class TitleSceneScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Move to game scene
	public void MoveToGameScene() {
		Debug.Log ("MoveToGameScene");
		Application.LoadLevel ("GameScene");
	}

	//Move to options scene
	public void MoveToOptionsScene() {
		Debug.Log ("MoveToOptionsScene");
		Application.LoadLevel ("OptionsScene");
	}
}
