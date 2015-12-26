using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void returnToScene() {
		Debug.Log ("returnToScene");

			Application.LoadLevel ("TitleScene");
	
	}
	
}
