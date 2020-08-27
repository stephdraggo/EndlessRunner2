using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    [RequireComponent(typeof(Rigidbody2D))]
    [AddComponentMenu("Runner/Player Control")]
    public class PlayerControl : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]
        public Rigidbody2D rigidBody;
        #endregion
        void Start()
        {
            rigidBody = GetComponent<Rigidbody2D>(); //connect rigidbody


        }

        void Update()
        {

        }
    }
}
/*
 public Animator animator;

 

    private void Start()
    {
            
    }
    void Update()
    {
        //make sure the "isRunning" is the same name as the bool in the animator
        animator.SetBool("isRunning", false); 
        
        if (Input.GetKey(KeyCode.D))
        {
            //if isRunning true then change to running animation 
            Debug.Log("isRunning");
            animator.SetBool("isRunning", true);
        }
        else
        {
            //else isRunning false then change to idle animation 
            animator.SetBool("isRunning", false);
        }
    }
 */
