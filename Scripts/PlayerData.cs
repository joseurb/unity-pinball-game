using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static string playerName; //= "Guest";
    public static int playerScore; //= 0;
    

    public void DeleteAllPlayersData()
    {
        PlayerPrefs.DeleteAll();
    }



}
