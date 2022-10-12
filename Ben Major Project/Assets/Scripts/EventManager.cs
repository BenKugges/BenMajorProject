using UnityEngine.SceneManagement;
using UnityEngine;

public class EventManager : MonoBehaviour
{
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreKeeper.Crates = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
