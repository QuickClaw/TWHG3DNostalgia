using UnityEngine;
using Steamworks;
using UnityEngine.SceneManagement;

public class SteamAchievements : MonoBehaviour
{
    int achievementCount;

    private void Awake()
    {
        achievementCount = SceneManager.GetActiveScene().buildIndex;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == achievementCount)
        {
            SteamUserStats.SetAchievement("achievement_" + achievementCount.ToString());
            SteamUserStats.StoreStats();
        }
    }

    private void Update()
    {
        if (!SteamManager.Initialized)
        {
            return;
        }
    }
}