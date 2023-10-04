using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public Variables Variables;
    public LevelLoader LevelLoader;

    public static int buildIndex = 0;

    public AudioSource endAudioSource;

    void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Variables.collectedGemsInLevel >= Variables.totalGemsInLevel)
        {
            if (other.tag is "Player")
            {
                endAudioSource.Play();
                Variables.collectedGemsInLevel = 0;

                Invoke(nameof(NextLevel), 0.1f);
            }
        }
    }

    public void NextLevel()
    {
        int saveIndex = PlayerPrefs.GetInt("saveIndex");

        if (buildIndex > saveIndex)
            PlayerPrefs.SetInt("saveIndex", buildIndex);

        PlayerPrefs.SetInt("buildIndex", buildIndex);

        LevelLoader.LoadLevel(buildIndex + 1);
    }
}
