using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed;
    public float afterSlowSpeed;

    void Update()
    {
        float leftRight = Input.GetAxisRaw("Horizontal");
        float forwardBackward = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(leftRight, 0.0f, forwardBackward) * speed * Time.deltaTime;

        transform.Translate(movement, Space.Self);

        #region Slow 
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 2;
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = afterSlowSpeed;
        }
        #endregion
    }
}
