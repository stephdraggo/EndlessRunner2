using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Collider2D))]
    [RequireComponent(typeof(Animator))]
    [AddComponentMenu("Runner/Player Control")]
    public class PlayerControl : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]
        public Rigidbody2D rigidBody;
        public Animator animator;

        public float jumpForce;

        public Collider2D lavaFloor, deathCeiling;

        public Menus menus;
        #endregion
        void Start()
        {
            rigidBody = GetComponent<Rigidbody2D>(); //connect rigidbody
            animator = GetComponent<Animator>(); //connect animator
        }

        void Update()
        {
            //speed up time

            //die on collision with ground


            //figure out how to only jump when not jumping

            if (Input.GetKeyDown(KeyCode.Space))
            {

                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);

                //change animator to jump

            }
            else
            {

                //animator.SetBool("boiRun", isRunning); //need to figure out what the "" is supposed to refer to

            }
        }

        public void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider == lavaFloor || collider == deathCeiling)
            {
                menus.GameOver();
            }
        }


    }
}
