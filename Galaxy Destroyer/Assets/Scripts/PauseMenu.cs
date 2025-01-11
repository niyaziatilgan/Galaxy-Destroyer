using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Pause Menüsü için UI Panel

    private bool isPaused = false; // Oyunun duraklatýlýp duraklatýlmadýðýný kontrol eder

    void Start()
    {
        // Oyun baþladýðýnda Pause Menüsü gizlenir
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;  // Oyun baþladýðýnda zaman ölçeði normal olmalý
    }

    void Update()
    {
        // ESC tuþuna basýldýðýnda Pause/Resume arasýnda geçiþ yap
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
        pauseMenuUI.SetActive(false); // Pause menüsünü kapat
        Time.timeScale = 1f;          // Oyunu normal hýzda çalýþtýr
        isPaused = false;
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true); // Pause menüsünü aç
        Time.timeScale = 0f;         // Oyunu durdur
        isPaused = true;
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // MainMenu'ya geçerken zaman ölçeðini 1 yap
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        Time.timeScale = 1f; // MainMenu'dan oyuna baþlarken zaman ölçeðini 1 yap
        SceneManager.LoadScene("MainLevel");
    }
}
