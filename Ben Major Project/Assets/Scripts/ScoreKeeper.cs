using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    //This script displays the number of crates collected to the player//
    public static int Crates = 0;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void OnGUI()
    {
        //This creates a gui box witha number in it, signifying the amount of crates collected//
        GUI.Box(new Rect(50, 50, 50, 25), Crates.ToString());
    }


    

}
