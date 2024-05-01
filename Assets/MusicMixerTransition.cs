using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicMixerTransitions : MonoBehaviour
{
    public AudioMixerSnapshot calmSnapshot;
    public AudioMixerSnapshot tensionSnapshot;
    public AudioMixerSnapshot otherSnapshot;

    private void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.tag)
        {
            case "Trigger Calm":
               calmSnapshot.TransitionTo(2f);
                break;
            case "Trigger Tension":
                tensionSnapshot.TransitionTo(2f);
                break;
            case "Trigger Other":
                otherSnapshot.TransitionTo(2f);
                break;
        }
    }
}
