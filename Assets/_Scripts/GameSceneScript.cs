using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSceneScript : MonoBehaviour {

	private GameController m_Control;

	// Use this for initialization
	void Start () {
		m_Control = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!m_Control.getIsGameStarted ()) {
			if (Input.touchSupported) {
				if (Input.touchCount > 0) {
					Touch touch = Input.GetTouch (0);
					if (touch.phase == TouchPhase.Ended) {
						startGame();
					}
				} 
			} else {
				if (Input.GetMouseButtonUp (0)) {
					startGame();
				}
			}
		}
	}

	public void startGame()
	{
		if (!m_Control.getIsGameStarted ()) {
			m_Control.setIsGameStarted (true);
			GameObject.Find("StartText").GetComponent<Text>().enabled = false;
		}
	}
}
