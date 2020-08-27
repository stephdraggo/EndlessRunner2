using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Animator))]
    [AddComponentMenu("Runner/Player Control")]
    public class PlayerControl : MonoBehaviour
    {
        #region Variables
        [Header("Reference Variables")]
        public Rigidbody2D rigidBody;
        public Animator animator;
        public bool isRunning;
        #endregion
        void Start()
        {
            rigidBody = GetComponent<Rigidbody2D>(); //connect rigidbody
            animator = GetComponent<Animator>(); //connect animator
            isRunning = false;
        }

        void Update()
        {

            //do this for the jump animation
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isRunning = !isRunning;
            }
            animator.SetBool("boiRun", isRunning); //need to figure out what the "" is supposed to refer to
        }
    }
}
/*
 public Animator anim; //This gives us access to the Animator from unity
    public bool run = false; //A bool is true or false
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();//get the correct animator in the scene/unity
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))//checks if the space key is pressed
        {
            run = !run; //changes run from false to true OR from true to false
        }
        anim.SetBool("Run", run);//Set our animatior parameter inside of unity (to the opposite of what it was before.)
    }
 */
