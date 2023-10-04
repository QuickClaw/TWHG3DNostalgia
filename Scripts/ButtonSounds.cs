using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource buttonAudioSource;

    public AudioClip clickSound; 
    public AudioClip highlightSound;

    public void ClickSound()
    {
        buttonAudioSource.PlayOneShot(clickSound);
    }

    public void HighlightSound()
    {
        buttonAudioSource.PlayOneShot(highlightSound);
    }
}
