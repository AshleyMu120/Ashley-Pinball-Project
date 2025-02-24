using UnityEngine;

public class mashmellow_audio : MonoBehaviour
{
    private AudioSource audioSource;

   
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.playOnAwake = false; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}