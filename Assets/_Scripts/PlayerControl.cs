using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	[SerializeField] private float m_MaxSpeed = 10f;                    // The fastest the player can travel in the x axis.
	[SerializeField] private float m_JumpForce = 400f;                  // Amount of force added when the player jumps.                

	//Variables
	public bool m_Grounded = false; 
	public Rigidbody2D m_Rigidbody2D;
	private Animator m_Anim;
	public bool m_Dead = false;
	private GameController m_Control;

	// Use this for initialization
	void Start () {
		m_Rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
		m_Anim = gameObject.GetComponent<Animator>();
		m_Control = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}

	private void FixedUpdate()
	{	
		// Set the vertical animation
		m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);
		
		if (m_Rigidbody2D.transform.position.y < -8) {
			m_Rigidbody2D.velocity = Vector2.zero;
			m_Rigidbody2D.gravityScale = 0;
		}
	}
	
	
	public void Move(float move, bool crouch, bool jump)
	{
		//only control the player if grounded or airControl is turned on
		if (m_Grounded)
		{
			// The Speed animator parameter is set to the absolute value of the horizontal input.
			m_Anim.SetFloat("Speed", Mathf.Abs(move));
			
			// Move the character
			m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, m_Rigidbody2D.velocity.y);
		}
		// If the player should jump...
		if (m_Grounded && jump && m_Anim.GetBool("Ground"))
		{
			// Add a vertical force to the player.
			//m_Grounded = false;
			m_Anim.SetBool("Ground", false);
			m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
			//Play sound
			SoundManagerScript.Instance.playEffect(SoundManagerScript.Instance.jump);
		}
	}

	public void Die()
	{
		if(!m_Dead)
		{
			m_Dead = true;
			//m_Rigidbody2D.gravityScale = 0;
			m_Rigidbody2D.angularVelocity = 0f;
			m_Rigidbody2D.rotation = 0f;
			m_Rigidbody2D.velocity = Vector2.zero;
			m_Rigidbody2D.AddForce (new Vector2 (0f, m_JumpForce * 1.1f));
			Physics2D.gravity = new Vector2(0, -30f);

			gameObject.GetComponent<BoxCollider2D>().isTrigger = true;

			m_Anim.SetBool ("Dead", true);

			if(m_Control)
			{
				StartCoroutine(m_Control.restartScene());
			}
		}
	}

	public void setGrounded(bool val)
	{
		if (val && !m_Grounded) {
			//Play sound
			SoundManagerScript.Instance.playEffect (SoundManagerScript.Instance.land);
		}

		m_Grounded = val;
		m_Anim.SetBool("Ground", m_Grounded);
	}
}
