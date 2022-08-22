using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public bool _isPlaySound = true;

    public Sound[] _sounds;

    private void Awake()
    {
        foreach(Sound sound in _sounds)
        {
            sound._audioSource = gameObject.AddComponent<AudioSource>();
            sound._audioSource.clip = sound._audioClip;

            sound._audioSource.volume = sound._volume;
            sound._audioSource.pitch = sound._pitch;
            sound._audioSource.loop = sound._loop;
        }
    }

    public void Play(string soundName)
    {
        Sound s = Array.Find(_sounds, Sound => Sound._name == soundName);

        if(s == null)
        {
            Debug.LogError(soundName + " this clip not found");
            return;
        }
        if(_isPlaySound)
            s._audioSource.Play();
    }
}
