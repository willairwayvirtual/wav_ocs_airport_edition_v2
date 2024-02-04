using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------ Audio Source -----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------ Audio Clip ------")]

    public AudioClip level12345678;
    public AudioClip pa1;

    {
        musicSource.clip = level12345678;
        musicSource.Play();
    }
}