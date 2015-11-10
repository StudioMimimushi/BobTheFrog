using UnityEngine;
using System.Collections;

public class ScoreCollideScript : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			ScoreScript.score++;
		}
	}
}
