using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputAudioSource : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private bool randomPitch;
    [SerializeField] private bool randomVolume;

    private void Start()
    {
        if(audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlaySound()
    {
        if (randomPitch) { audioSource.pitch = Random.Range(audioSource.pitch + 0.1f, audioSource.pitch  - 0.1f); }
        if (randomVolume) { audioSource.volume = Random.Range(audioSource.volume - 0.2f, audioSource.volume + 0.2f); }
        audioSource.Play();
    }
}
