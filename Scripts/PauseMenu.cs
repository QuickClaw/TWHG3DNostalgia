using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public TPS TPS;
    public Movement Movement;

    public GameObject pausePanel;

    bool paused;

    void Start()
    {
        pausePanel.SetActive(false);
        paused = false;
    }

    void Update()
    {
        PauseAndResume();
    }

    // Oyunu durdurur ve baþlatýr.
    void PauseAndResume()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == false)
            {
                Time.timeScale = 0f;
                pausePanel.SetActive(true);

                paused = true;

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                TPS.enabled = false;
                Movement.enabled = false;
            }
            else
            {
                Time.timeScale = 1f;
                pausePanel.SetActive(false);

                paused = false;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                TPS.enabled = true;
                Movement.enabled = true;
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);

        paused = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        TPS.enabled = true;
        Movement.enabled = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        Variables.collectedGemsInLevel = 0;
        SceneManager.LoadScene("Main Menu");

        paused = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

