using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This script uses scenemanager to make the maze level load when the start button is pressed//
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    
    

}
