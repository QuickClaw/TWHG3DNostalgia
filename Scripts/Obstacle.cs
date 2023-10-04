using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public Movement Movement;
    public CameraShake CameraShake;
    public Texts Texts;
    readonly Variables Variables;

    public static bool isDead;
    public float respawnTime;

    public ParticleSystem deathEffect;
    public AudioSource deathAudioSource;

    public Vector3 respawnLocation;

    public float shakeDuration, shakeMagnitude;

    public TMP_Text txtDeaths;
    public TMP_Text txtLevelCount;

    Collider playerCollider;

    void Start()
    {
        isDead = false;
        playerCollider = gameObject.GetComponent<Collider>();

        Movement.enabled = true;
        respawnLocation = transform.position;

        txtDeaths.text = "Deaths: " + Variables.death.ToString();
        txtLevelCount.text = "Level " + SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isDead == false)
        {
            if (other.tag is "Enemy")
            {
                StartCoroutine(CameraShake.Shake(shakeDuration, shakeMagnitude));
                playerCollider.enabled = false;

                Variables.death += 1;
                PlayerPrefs.SetInt("Deaths", Variables.death);

                Texts.txtDeaths.text = "Deaths: " + Variables.death.ToString();

                Variables.collectedGemsInLevel = 0;
                Texts.txtGems.text = "Gems: " + Variables.collectedGemsInLevel.ToString() + "/" + Variables.totalGemsInLevel.ToString();

                Movement.enabled = false;
                isDead = true;

                deathEffect.Play();
                deathAudioSource.Play();

                Invoke(nameof(Respawn), respawnTime);
            }
        }
    }

    void Respawn()
    {
        transform.position = respawnLocation;
        isDead = false;
        Movement.enabled = true;
        Movement.speed = 3.8f;
        playerCollider.enabled = true;
    }
}
