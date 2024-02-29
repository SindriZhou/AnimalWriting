using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SdM_ui : MonoBehaviour
{
    public static SdM_ui instance;

    public AudioSource audioSource;
    [SerializeField]
    private AudioClip GameStart,HomeDoor,FillInfo,NewQuest;

    public void Awake()
    {
        instance = this;
    }

    public void IsStart()
    {
        audioSource.clip = GameStart;
        audioSource.Play();
    }

    public void Home()
    {
        audioSource.clip = HomeDoor;
        audioSource.Play();
    }

    public void Info()
    {
        audioSource.clip = FillInfo;
        audioSource.Play();
    }

    public void Quest()
    {
        audioSource.clip = NewQuest;
        audioSource.Play();
    }
}
