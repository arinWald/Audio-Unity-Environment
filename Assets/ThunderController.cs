using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ThunderController : MonoBehaviour
{
    public AudioClip thunderSound;
    private AudioSource audioSource;

    // Adjust these values as per your requirement
    public float minDelay = 15f;
    public float maxDelay = 30f;

    private void Start()
    {
        // Get the AudioSource component from the GameObject
        audioSource = GetComponent<AudioSource>();

        // Start the coroutine to play thunder sounds at random intervals
        StartCoroutine(PlayThunderSound());
    }

    IEnumerator PlayThunderSound()
    {
        while (true)
        {
            // Wait for a random interval between minDelay and maxDelay
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));

            // Play the thunder sound
            if (thunderSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(thunderSound);
            }
        }
    }
}

