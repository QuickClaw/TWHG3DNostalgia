using UnityEngine;
using TMPro;

public class VariableManager : MonoBehaviour
{
    public TMP_Text txtDeaths;
    public TMP_Text txtGems;

    void Start()
    {


        txtDeaths.text = "Deaths: " + PlayerPrefs.GetInt("Deaths").ToString();
        txtGems.text = "Gems: " + PlayerPrefs.GetInt("Gems").ToString();
    }
}
