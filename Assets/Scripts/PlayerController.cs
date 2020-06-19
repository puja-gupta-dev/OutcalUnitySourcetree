using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {

        private Animator _animator;

        [SerializeField]
        private BoxCollider2D _colliderCrouch;
        // Start is called before the first frame update
        void Start()
        {
            _animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            float speedVer = Input.GetAxisRaw("Vertical");
            float speed = Input.GetAxisRaw("Horizontal");

            PlayerMovement(speed, speedVer);
            PlayCrouchAnimation();
        }

        private void PlayCrouchAnimation()
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                _animator.SetBool("isCrouch", true);
                _colliderCrouch.gameObject.SetActive(true);
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                _animator.SetBool("isCrouch", false);
                _colliderCrouch.gameObject.SetActive(false);
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
        }

        void PlayerMovement(float horizontal,float vertical)
        {
           
         _animator.SetFloat("speed", Mathf.Abs(horizontal));
            Vector3 scale = transform.localScale;
            if (horizontal < 0)
            {
                scale.x = -1f * Mathf.Abs(scale.x);
                transform.localScale = scale;
            }
            else if (horizontal > 0)
            {
                scale.x = Mathf.Abs(scale.x);
                transform.localScale = scale;
            }


            if (vertical > 0)
                _animator.SetFloat("speedVer", vertical);

        }
    }
}
