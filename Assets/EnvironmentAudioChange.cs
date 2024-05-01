using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnvironmentAudioChange : MonoBehaviour
{
    public AudioMixerSnapshot exteriorSnapshot;
    public AudioMixerSnapshot interiorSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Interior")
        {
            interiorSnapshot.TransitionTo(0.5f);
            Debug.Log("PILOTA");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        exteriorSnapshot.TransitionTo(0.5f);
    }

}
