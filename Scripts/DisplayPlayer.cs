using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayPlayer : MonoBehaviour
{
    public TextMeshProUGUI userName;

    // Start is called before the first frame update

    public void DisplayPlayerInGame()
    {
        userName.text = PlayerData.playerName;
    }
    void Start()
    {
        DisplayPlayerInGame();
    }
}
