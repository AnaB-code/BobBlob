using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button[] buttons;
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);
        
        for(int i = 0; i < buttons.Length; i++)
        {
            if(i + 2 > levelAt)
            {
                buttons[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
   
}
