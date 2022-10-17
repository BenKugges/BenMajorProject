using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //This script controls the movement animations of the player//
   
    public Animator scavMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //This function controls the animation of the player. When one of the movement keys is held down it will play the running animation of the character. If no movement keys are held the idle animation will play.//
        //Inputs - W,A,S,D//
        //Outputs - Character Animation//
        if (Input.GetKey(KeyCode.W))
        {
            scavMovement.SetBool("isRunning", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            scavMovement.SetBool("isRunning", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            scavMovement.SetBool("isRunning", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            scavMovement.SetBool("isRunning", true);
             
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            scavMovement.SetBool("isRunning", false);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            scavMovement.SetBool("isRunning", false);

        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            scavMovement.SetBool("isRunning", false);

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            scavMovement.SetBool("isRunning", false);

        }
    }


}
