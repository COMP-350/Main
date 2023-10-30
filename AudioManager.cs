using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Source ---------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio Clips ---------")]
    public AudioClip background;
    public AudioClip punch;
    public AudioClip splash;
    public AudioClip menubutton;
    public AudioClip croak;
    public AudioClip splatter;
    public AudioClip jump;

    private void Start() {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip) {
        SFXSource.PlayOneShot(clip);
    }
}
