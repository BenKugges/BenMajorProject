using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

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
        GUI.Box(new Rect(50, 50, 50, 25), Crates.ToString());
    }


    

}