using UnityEngine;
public class TPS : MonoBehaviour
{
    public float upLimit, downLimit;
    private float mouseX, mouseY;
    public float interpolatedTime = 0;

    public Transform target, player;
    public Camera Camera;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Camera.fieldOfView = 110;
    }

    void LateUpdate()
    {
        CameraControl();
    }

    private void Update()
    {
        Zoom();
    }

    public void CameraControl()
    {
        mouseX += Input.GetAxis("Mouse X") * 1.5f;
        mouseY += Input.GetAxis("Mouse Y") * -1.5f;
        mouseY = Mathf.Clamp(mouseY, downLimit, upLimit);

        transform.LookAt(target);

        target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);
    }

    public void Zoom()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Camera.fieldOfView += 2.5f;
            Camera.fieldOfView = Mathf.Clamp(Camera.fieldOfView, 45, 110);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Camera.fieldOfView -= 2.5f;
            this.interpolatedTime += Time.deltaTime;
            Camera.fieldOfView = Mathf.Clamp(Camera.fieldOfView, 45, 110);
        }
    }
}

