using UnityEngine;
using TMPro;

public class GemPickup : MonoBehaviour
{
    public Variables Variables;
    public Obstacle Obstacle;
    public Texts Texts;

    public TMP_Text txtGems;

    public ParticleSystem gemEffect;

    public AudioSource gemAudioSource;
    public AudioClip[] shoot;
    private AudioClip shootClip;

    public Vector3 posGem;

    void Start()
    {
        posGem = transform.position;
        gemAudioSource.volume = 0.32f;

        Texts.txtGems.text = "Gems: " + Variables.collectedGemsInLevel.ToString() + "/" + Variables.totalGemsInLevel.ToString();
    }

    private void Update()
    {
        transform.Rotate(0, 0.17f, 0 * Time.deltaTime);

        if (Obstacle.isDead)
            ResetGemLocation();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Player")
        {
            transform.position = new Vector3(0, 5000, 0);

            Variables.totalGems++;
            PlayerPrefs.SetInt("Gems", Variables.totalGems);

            Variables.collectedGemsInLevel++;

            Texts.txtGems.text = "Gems: " + Variables.collectedGemsInLevel.ToString() + "/" + Variables.totalGemsInLevel.ToString();

            gemEffect.Play();

            int index = Random.Range(0, shoot.Length);
            shootClip = shoot[index];
            gemAudioSource.clip = shootClip;
            gemAudioSource.Play();
        }
    }

    void ResetGemLocation()
    {
        transform.position = posGem;
    }
}