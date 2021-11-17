using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Button[] buttons;
    public AudioClip[] audioClips;
    Dictionary<Button, AudioClip> dict = new Dictionary<Button, AudioClip>();
    void Start()
    {
        for (int i = 0; i<3; i++ )
        {
            dict.Add(buttons[i], audioClips[i]);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
