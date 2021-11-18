using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Button[] buttons;
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    Dictionary<Button, AudioClip> dict = new Dictionary<Button, AudioClip>();
    int i;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();


        //for (int i = 0; i < dict.Count; i++)
        //{
        //    dict.Add(buttons[i], audioClips[i]);

        //}


    }

    
}
