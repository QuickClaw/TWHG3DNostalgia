using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCamera : MonoBehaviour
{
    public Camera mainCam, birdsEyeCam;
    void Start()
    {
        mainCam.enabled = false;
        birdsEyeCam.enabled = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
