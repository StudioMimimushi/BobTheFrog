using UnityEngine;
using System.Collections;

public class CreditsScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void returnToScene() {
		LevelManager.changeToPreviousLvl ();
		
	}
}
