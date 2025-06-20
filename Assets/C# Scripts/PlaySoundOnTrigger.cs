using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    private AudioSource audioSource; // Reference to the AudioSource component

    void Awake()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("PlaySoundOnTrigger: No AudioSource found on this GameObject!", this);
        }
    }

    // This function is called when another collider enters this trigger
    void OnTriggerEnter(Collider other)
    {
        // Optional: Check if the colliding object is a specific tag (e.g., "Player" or "Hand")
        // This prevents the sound from playing if anything else touches the trigger.
        // You can tag your LeftHand Controller, RightHand Controller, or XR Origin as "Hand" or "Player"
        if (other.CompareTag("Hand") || other.CompareTag("Player"))
        {
            // Play the sound once
            if (audioSource != null && !audioSource.isPlaying) // Check if sound isn't already playing
            {
                audioSource.Play();
                Debug.Log($"Sound played by: {other.name} hitting {gameObject.name}");
            }
        }
    }

    // Optional: If you want sound to stop when leaving the trigger
    /*
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hand") || other.CompareTag("Player"))
        {
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
    */
}