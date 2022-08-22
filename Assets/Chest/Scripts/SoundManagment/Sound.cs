using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string _name;

    public AudioClip _audioClip;

    [Range(0f, 1f)]
    public float _volume = 0.5f;

    [Range(-3f, 3f)]
    public float _pitch = 1f;

    public bool _loop = false;

    [HideInInspector]
    public AudioSource _audioSource;
}
