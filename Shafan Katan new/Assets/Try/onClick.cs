using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class onClick : MonoBehaviour
{
    
    private SoundManager soundScript;
   




	public void Start()
	{
		for (int i = 0; i < soundScript.buttons.Length; i++)
		{
			Button button = soundScript.buttons[i];
			button.onClick.RemoveAllListeners();
			button.onClick.AddListener(() => OnClick(i));
		}
	}

	private void OnClick(int index)
	{
		Debug.Log("You click button at index: " + index);
	}

}




