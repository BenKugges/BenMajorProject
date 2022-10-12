using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour


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
            Instantiate(EscapeRoute, new Vector3(-4f, -0.77f, -6f), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    

}
