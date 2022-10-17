using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemCollection : MonoBehaviour

    //This script is used to update the number of crates collected//
{

    
    private void OnTriggerEnter(Collider other)
    {
        //Destroys the crate and adds 1 to the number of crates//
        Destroy(gameObject);
        ScoreKeeper.Crates += 1;
      
      
    }

    void Update()
    {
        
    }

}
