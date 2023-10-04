using UnityEngine;

public class Variables : MonoBehaviour
{
    public static int death;
    public static int totalGems;

    public static int totalGemsInLevel;
    public static int collectedGemsInLevel;

    private void Awake()
    {
        death = PlayerPrefs.GetInt("Deaths");
        totalGems = PlayerPrefs.GetInt("Gems");

        totalGemsInLevel = FindObjectsOfType<GemPickup>().Length;
    }
}
