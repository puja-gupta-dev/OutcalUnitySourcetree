using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float speedHorizontal = 4f;

        [SerializeField]
        private float upwardForce = 4f;

        private Animator animator;
        private Rigidbody2D rigidBody2D;

        // Start is called before the first frame update
        private void Start()
        {
            animator = GetComponent<Animator>();
            rigidBody2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        private void Update()
        {
            float speed = Input.GetAxisRaw("Horizontal");
            float speedJump = Input.GetAxisRaw("Jump");

            PlayerMovement(speed,speedJump);
            TranslatePlayer(speed, speedJump);
        }

       

        private void PlayerMovement(float horizontal,float vertical)
        {
            animator.SetFloat("speed", Mathf.Abs(horizontal));
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


            if(vertical > 0)
            {
                animator.SetBool("canJump", true);  
            }
            else 
            {
                animator.SetBool("canJump", false);   
            } 

        }

        private void TranslatePlayer(float horizontal,float vertical)
        {
            Vector3 pos = transform.position;
            pos.x += horizontal * speedHorizontal * Time.deltaTime;

            transform.position = pos;

            if(vertical>0)
                rigidBody2D.AddForce(Vector2.up * upwardForce, ForceMode2D.Force);
        }
    }
}
