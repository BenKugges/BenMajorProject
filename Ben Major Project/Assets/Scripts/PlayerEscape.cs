using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEscape : MonoBehaviour


{
    public GameObject gameCompletedPanel;
    //This script will destroy the player, making it seem as if they have escaped//

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Escape"))
        {
            //This destroys the player and displays the game won screen//
            Destroy(gameObject);
            gameCompletedPanel.SetActive(true);
        }
        
        


    }

}
