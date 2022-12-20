using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadSavedData : MonoBehaviour
{
    public TextMeshProUGUI data;

    public void LoadData()
    {
        string playerIdx = "";
        string numIdx = "";

        for (int i = 10; i >= 1; i--)
        {
            playerIdx = i.ToString();
            data.text += PlayerPrefs.GetString(playerIdx) + ": ";
            numIdx = (-1 * i).ToString();
            data.text += PlayerPrefs.GetInt(playerIdx) + "\n";

        }

    }

    public void ClearLoadedData()
    {
        data.text = "";
    }
}
