using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] LevelButtons;
    public RawImage[] LockImages;

    private void Start()
    {
        int saveIndex = PlayerPrefs.GetInt("saveIndex");

        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i <= saveIndex)
            {
                LevelButtons[i].interactable = true;
                LockImages[i].gameObject.SetActive(false);
                LevelButtons[i].GetComponent<Image>().raycastTarget = true;

            }
            else
            {
                LevelButtons[i].interactable = false;
                LockImages[i].gameObject.SetActive(true);
                LevelButtons[i].GetComponent<Image>().raycastTarget = false;
            }
        }
    }
    public void Continue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("saveIndex") + 1);
    }
}

