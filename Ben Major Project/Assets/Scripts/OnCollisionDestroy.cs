using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour
{
    //This activates or deactivates the game over panel and also destroys the player when they collide with the enemy//
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //If the object the enemy collides with is the player it will destroy them and enable the game over panel//
            Destroy(other.gameObject);
            gameOverPanel.SetActive(true);
        }
    

            

        

    }



}
