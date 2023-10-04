using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ButtonManager : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject newGamePanel;
    public GameObject levelSelectPanel;
    public GameObject creditsPanel;

    public RawImage videoPanel;

    public VideoPlayer videoPlayer;
    public VideoClip[] levelVideos;

    bool newGamePanelOpened;
    bool creditsPanelOpened;

    void Start()
    {
        newGamePanelOpened = false;
        creditsPanelOpened = false;
        videoPanel.enabled = false;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    #region New Game

    // Yeni oyun panelini a�ar.
    public void OpenNewGamePanel()
    {
        if (newGamePanelOpened == false)
        {
            newGamePanel.SetActive(true);
            newGamePanelOpened = true;
        }
    }

    // Yeni oyun panelini kapat�r.
    public void CloseNewGamePanel()
    {
        if (newGamePanelOpened == true)
        {
            newGamePanel.SetActive(false);
            newGamePanelOpened = false;
        }
    }

    #endregion

    #region Credits

    // Credits panelini a�ar, kapat�r.
    public void OpenCloseCreditsPanel()
    {
        if (creditsPanelOpened == false)
        {
            creditsPanel.SetActive(true);
            creditsPanelOpened = true;
        }
        else
        {
            creditsPanel.SetActive(false);
            creditsPanelOpened = false;
        }
    }

    #endregion

    #region My Other Games

    // Oyuncuyu Steam'deki geli�tirici sayfama y�nlendirir.
    public void OpenURL()
    {
        Application.OpenURL("https://store.steampowered.com/developer/zummar");
    }

    #endregion

    #region Quit

    // Oyundan ��kar.
    public void Quit()
    {
        Application.Quit();
    }

    #endregion

    #region Yes

    // B�t�n ilerlemeyi siler ve 1. b�l�mden oyuna ba�lar.
    public void StartNewGame()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Level 1");
    }
    #endregion

    #region Video
    public void PlayLevelVideo(int videoIndex)
    {
        videoPanel.enabled = true;
        videoPlayer.clip = levelVideos[videoIndex];
    } 
    
    public void DontPlayLevelVideo()
    {
        videoPanel.enabled = false;
    }
    #endregion
}
