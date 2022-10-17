using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //This script controls the player and the player picking up powerups, as well as the powerup timer.//
    public CharacterController controller;
    public bool hasPowerUp = false;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public float numberCollected;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //This controls the movement of the character. It calculates the angle that the character should be facing and turns the front of the player towards that angle.
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            controller.Move(direction * speed * Time.deltaTime);
        }

        //These functions control the powerups. The powerups increase the player speed from 4.5 to 8//
        if (hasPowerUp == true)
        {
            speed = 8f;
        }

        if (hasPowerUp == false)
        {
            speed = 4.5f;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            //If the player has the powerup it will start the coroutine which counts down the powerup duration//
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());

        }


    }

    IEnumerator PowerupCountdownRoutine()
    {
        //After 10 seconds the speed powerup will be disabled//
        yield return new WaitForSeconds(10);
        hasPowerUp = false;
    }

    
    

}

