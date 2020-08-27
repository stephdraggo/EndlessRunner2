using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
//also add box collider (not 2d) on both player and obstacles, floor

public class PlayerController : MonoBehaviour
{
    CharacterController charControl;
    public GameObject deathScreen;

    public Vector2 moveVector;

    public float vertVel = 0f;
    public float gravity = 50f;
    public float gravityUp = 50f;
    public float gravityDn = 60f;
    public float jumpForce = 16f;

    public float timeScore;

    void Start()
    {
        Time.timeScale = 1;
        charControl = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveVector = Vector2.zero;

        if (charControl.isGrounded)
        {
            vertVel = -0.5f;
            vertVel = -gravity * Time.deltaTime;
            if (Input.GetKey(KeyCode.Space))
            {
                vertVel = jumpForce;
                gravity = gravityUp;
            }
        }
        else
        {
            vertVel -= gravity * Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            gravity = gravityDn;
        }

            moveVector.y = vertVel;

        charControl.Move(moveVector * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Damage")
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0;
            timeScore = Time.timeSinceLevelLoad;

            //if high score < time score, set high score to time score
            if(MainMenu.highScore < timeScore)
            {
                MainMenu.highScore = timeScore;
            }

            Debug.Log("time score is: " + timeScore);
            Debug.Log("high score is: " + MainMenu.highScore);
        }
    }
    
}
