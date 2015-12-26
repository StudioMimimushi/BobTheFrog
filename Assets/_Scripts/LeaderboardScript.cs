using UnityEngine;
using System.Collections;

public class LeaderboardScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void returnToGameOver() 
	{
		Debug.Log ("returnToGameOver");		
		Application.LoadLevel ("GameOverScene");
		
	}
}
