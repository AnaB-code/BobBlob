using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
   
    void Start()
    {
        
        Button buttonReference = gameObject.GetComponent<Button>();

       
        buttonReference.onClick.AddListener(whenClicked);
    }

    void whenClicked()
    {
        SceneManager.LoadScene("Gameplayscene");
        Debug.Log("Button Clicked");
    }
}
