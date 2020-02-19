using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Audio
{
    public bool loop;
    public string name;
    [Range(0, 1)]
    public float volume;
    [Range(0, 1)]
    public float pitch;
    public AudioClip clip;
    [HideInInspector]
    public AudioSource source;
}
