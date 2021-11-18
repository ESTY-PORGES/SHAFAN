using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class onClick : MonoBehaviour
{
    [SerializeField]
    private SoundManager soundManager;

    private int numKeyPreesd;

   

    public void OnClickKey()
    {
        numKeyPreesd = EventSystem.current.currentSelectedGameObject.GetComponent<Key>().GetbuttonNum();

        soundManager.audioSource.clip = soundManager.audioClips[numKeyPreesd];
        soundManager.audioSource.Play();

        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        Debug.Log(EventSystem.current.currentSelectedGameObject.GetComponent<Key>().GetbuttonNum());

        //EventSystem.current.currentSelectedGameObject.transform.position = Vector3.Lerp(EventSystem.current.currentSelectedGameObject.transform.position, System.Array.IndexOf(vector3array, currentObject) vector3array[currentObject.index], Time.deltaTime);

        //System.Array.IndexOf(soundManager.buttons) vector3array[currentObject.index]

        //EventSystem.current.currentSelectedGameObject.Array.IndexOf(soundManager.buttons);

    }


}




