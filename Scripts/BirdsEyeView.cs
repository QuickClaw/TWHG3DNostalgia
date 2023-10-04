using UnityEngine;

public class BirdsEyeView : MonoBehaviour
{
    public GameObject mainCam, birdsEyeCam;
    public static bool camNormal;
    public Movement Movement;

    private void Start()
    {
        camNormal = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camNormal = !camNormal;
            Movement.enabled = !Movement.enabled;
        }

        if (camNormal == true)
        {
            mainCam.SetActive(true);
            birdsEyeCam.SetActive(false);
        }

        if (camNormal == false)
        {
            mainCam.SetActive(false);
            birdsEyeCam.SetActive(true);
            Movement.enabled = false;
        }
    }
}
