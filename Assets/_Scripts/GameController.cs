using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private bool m_bGameStarted;
	public float m_fStartSpeed = 1f;
	public float m_fMaxSpeed = 2f;
	private float m_fGameSpeed;

	// Use this for initialization
	void Awake()
	{
		m_bGameStarted = false;
		m_fGameSpeed = m_fStartSpeed;
	}

	void Start () {

	}

	void Update()
	{
		if (m_bGameStarted) {
			float timer = Time.deltaTime;
			m_fGameSpeed += (timer / 100f);
			m_fGameSpeed = Mathf.Min (m_fGameSpeed, m_fMaxSpeed);
		}
	}
	
	public void setIsGameStarted(bool val)
	{
		m_bGameStarted = val;
	}

	public bool getIsGameStarted()
	{
		return m_bGameStarted;
	}

	public float getGameSpeed()
	{
		return m_fGameSpeed;
	}

	public IEnumerator restartScene()
	{
		yield return new WaitForSeconds(2);
		Application.LoadLevel("GameScene");
	}
}
