using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameEntry : MonoBehaviour
{
    public TMP_InputField inputBox;
    
    public void SetEnterName()
    {

        if (inputBox.text == "")
        {
            PlayerData.playerName = "Guest";
        }
        else
            PlayerData.playerName = inputBox.text;

        Debug.Log(PlayerData.playerName);

    }
}
