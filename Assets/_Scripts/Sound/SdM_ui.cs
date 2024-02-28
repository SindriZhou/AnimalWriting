using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdM_ui : MonoBehaviour
{
    public static SdM_ui instance;

    public AudioSource audioSource;
    [SerializeField]
    private AudioClip GameStart;

    public void Awake()
    {
        instance = this;
    }

    public void IsStart()
    {
        audioSource.clip = GameStart;
        audioSource.Play();
    }

    
}
