using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameSceneScript : MonoBehaviour {

	private GameController m_Control;
	public bool pauseButton;

	// Use this for initialization
	void Start () {
		pauseButton = true;
		m_Control = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		LevelManager.setLastLevel(Application.loadedLevelName);
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

	public void menuButton()
	{
		if (pauseButton) {
			Time.timeScale = 0;
			pauseButton = false;
		}
		if (!pauseButton)
		{
			Time.timeScale = 1;
			pauseButton = true;
		}
		//Time.timescale = 0.0;
		
	}
}
