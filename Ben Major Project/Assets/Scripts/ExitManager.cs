using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
    //This script spawns the exit when all crates are collected//

{
    public GameObject EscapeRoute;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreKeeper.Crates == 7)
        {
            //If the number of crates = 7, the escape route will spawn//
            Instantiate(EscapeRoute, new Vector3(-4f, -0.77f, -6f), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    

}
