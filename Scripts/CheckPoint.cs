using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Obstacle Obstacle;

    public Vector3 checkPoint;
    public bool checkPointed;

    void Start()
    {
        checkPoint = new Vector3(transform.position.x, 0.3f, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Player")
        {
            checkPointed = true;
            Obstacle.respawnLocation = checkPoint;
        }
    }
}
