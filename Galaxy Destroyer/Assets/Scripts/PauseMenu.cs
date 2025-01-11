using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Pause Men�s� i�in UI Panel

    private bool isPaused = false; // Oyunun duraklat�l�p duraklat�lmad���n� kontrol eder

    void Start()
    {
        // Oyun ba�lad���nda Pause Men�s� gizlenir
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;  // Oyun ba�lad���nda zaman �l�e�i normal olmal�
    }

    void Update()
    {
        // ESC tu�una bas�ld���nda Pause/Resume aras�nda ge�i� yap
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false); // Pause men�s�n� kapat
        Time.timeScale = 1f;          // Oyunu normal h�zda �al��t�r
        isPaused = false;
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true); // Pause men�s�n� a�
        Time.timeScale = 0f;         // Oyunu durdur
        isPaused = true;
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // MainMenu'ya ge�erken zaman �l�e�ini 1 yap
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        Time.timeScale = 1f; // MainMenu'dan oyuna ba�larken zaman �l�e�ini 1 yap
        SceneManager.LoadScene("MainLevel");
    }
}
