using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class PControls : MonoBehaviour
    {

        public PlatformerCharacter2D m_Character;
        private bool m_Jump = false;
        private float Hmovement = 0f;
        // Start is called before the first frame update
        void Start()
        {

        }

        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }

        private void FixedUpdate()
        {
            // Read the inputs.
            //bool crouch = Input.GetKey(KeyCode.LeftControl);
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(Hmovement, false, m_Jump);
            m_Jump = false;

        }

        public void MoveLeft()
        {
            Hmovement = 1.0f;
        }

        public void MoveLeftUp()
        {
            Hmovement = 0.0f;
        }

        public void MoveRight()
        {
            Hmovement = 10.0f;
        }

        public void MoveRightUp()
        {
            Hmovement = 0.0f;
        }
    }
}
