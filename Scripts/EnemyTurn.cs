using UnityEngine;

public class EnemyTurn : MonoBehaviour
{
    public Vector3 turnVector;

    private void Update()
    {
        transform.Rotate(turnVector * Time.deltaTime);
    }
}
