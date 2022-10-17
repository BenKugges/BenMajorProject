using UnityEngine.SceneManagement;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    //This script reloads the level after the replay button is clicked//
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReplayLevel()
    {
        //This function is used by another script to reset the level and reset the number of crates collected//
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreKeeper.Crates = 0;
    }

    

}
