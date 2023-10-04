using UnityEngine;
using TMPro;

public class EndVariables : MonoBehaviour
{
    public TMP_Text txtDeath;

    void Start()
    {
        txtDeath.text = "Deaths: " + Variables.death.ToString();
    }
}
