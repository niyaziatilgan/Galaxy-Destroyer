using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartControl : MonoBehaviour
{
    public GameObject restartCanvas; 
    public float delayTime = 45f;    

    void Start()
    {
        if (restartCanvas != null)
        {
            restartCanvas.SetActive(false);
        }

        Invoke("ShowRestartCanvas", delayTime);
    }

    void ShowRestartCanvas()
    {
        if (restartCanvas != null)
        {
            restartCanvas.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f; 
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f; 
    }

    public void QuitGame()
    {
        Debug.Log("Game is quitting...");
        Application.Quit();
    }
}
