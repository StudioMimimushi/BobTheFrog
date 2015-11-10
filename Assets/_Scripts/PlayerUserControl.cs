using UnityEngine;
using System.Collections;

public class PlayerUserControl : MonoBehaviour {
	public float speed = 0.1f;
	private PlayerControl m_Character;
	private bool m_Jump;
	private GameController m_Control;

	public float m_gravity = -30f;
	public float m_floatGravity = -20f;  
	
	private void Awake()
	{
		m_Character = GetComponent<PlayerControl>();
		m_Control = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}

	
	private void Update()
	{
		if (m_Control && m_Control.getIsGameStarted ()) {
			if (!m_Jump && !m_Character.m_Dead) {
				// Read the jump input in Update so button presses aren't missed.
				if (Input.touchSupported) {
					if (Input.touchCount > 0) {
						Touch touch = Input.GetTouch (0);
						if (touch.phase == TouchPhase.Began) {
							//Jump
							m_Jump = true;
							Physics2D.gravity = new Vector2(0, m_floatGravity);
						} else if (touch.phase == TouchPhase.Ended) {
							Physics2D.gravity = new Vector2(0, m_gravity);
						}
					} 
				} else {
					if (Input.GetMouseButtonDown (0)) {
						Debug.Log ("Mouse down");
						m_Jump = true;
						Debug.Log(Physics2D.gravity);
						Physics2D.gravity = new Vector2(0, m_floatGravity);
					} else if (Input.GetMouseButtonUp (0)) {
						Debug.Log ("Mouse up");
						Debug.Log(Physics2D.gravity);
						Physics2D.gravity = new Vector2(0, m_gravity);
					}
				}
			}
		}
	}
	
	
	private void FixedUpdate()
	{
		if (m_Control && m_Control.getIsGameStarted ()) {
			// Read the inputs.
			if (!m_Character.m_Dead) {
				m_Character.Move (speed*m_Control.getGameSpeed(), false, m_Jump);
				m_Jump = false;
			}
		}
	}
}