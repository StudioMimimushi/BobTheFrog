using UnityEngine;
using System.Collections;

public class GroundCheckScript : MonoBehaviour {

	private PlayerControl player;
	[SerializeField] private LayerMask m_WhatIsGround;  
	const float k_GroundedRadius = .2f;

	// Use this for initialization
	void Start () {
		player = gameObject.GetComponentInParent<PlayerControl>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.layer  == m_WhatIsGround) {
			player.setGrounded(true);
		/*}
		if (val && m_Grounded != val) {*/
			//Play sound
			SoundManagerScript.Instance.playEffect (SoundManagerScript.Instance.land);
		}
	}

	/*void OnTriggerExit2D(Collider2D col)
	{

		if (col.gameObject.layer  == m_WhatIsGround) {
			player.setGrounded(false);
		}
	}*/

	private void FixedUpdate()
	{	
		bool grounded = false; 

		// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
		// This can be done using layers instead but Sample Assets will not overwrite your project settings.
		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, k_GroundedRadius, m_WhatIsGround);
		for (int i = 0; i < colliders.Length; i++) {
			if (colliders [i].gameObject != gameObject)
				grounded = true;
		}

		player.setGrounded (grounded);
	}
}
