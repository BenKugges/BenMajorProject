using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemCollection : MonoBehaviour

    
{

    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        ScoreKeeper.Crates += 1;
      
      
    }

    void Update()
    {
        
    }

}
