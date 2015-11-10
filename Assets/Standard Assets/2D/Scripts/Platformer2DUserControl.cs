using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
		public float speed = 0.1f;
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
				if (Input.touchSupported) {
					if (Input.touchCount > 0) {
						Touch touch = Input.GetTouch (0);
						if (touch.phase == TouchPhase.Began) 
						{
							//Jump
							m_Jump = true;
						}
					} 
				}else
				{
					if(Input.GetMouseButtonDown(0))
					{
						m_Jump = true;
					}
				}
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            //bool crouch = Input.GetKey(KeyCode.LeftControl);
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
			if (!m_Character.m_Dead) {
				m_Character.Move (speed, false, m_Jump);
				m_Jump = false;
			}
        }
    }
}
