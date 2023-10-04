using UnityEngine;

public class MenuDeath : MonoBehaviour
{
    bool dead;
    public MenuMovement MenuMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dead == false)
        {
            if (collision.gameObject.tag is "Enemy")
            {
                dead = true;
                MenuMovement.enabled = false;
                Invoke(nameof(ResetPosition), 1f);
            }
        }
    }

    void ResetPosition()
    {
        dead = false;
        gameObject.transform.localPosition = new Vector3(-493f, -380f, 0);       
        MenuMovement.enabled = true;
    }
}
