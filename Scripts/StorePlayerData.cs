using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorePlayerData : MonoBehaviour
{
    int numberOfPlayers = 1;
    string playerIdx = "1";
    int numIdx = 1;
    bool isKeyEmpty = true;
   public void StoreData()
    {
        //code not functional/ do not delete might break something
        while (numberOfPlayers <= 10 && isKeyEmpty == true) //&& PlayerPrefs.HasKey(playerIdx) == true && dubplicateFound == false)
        {
            playerIdx = numberOfPlayers.ToString();
            numIdx = -1 * numberOfPlayers;
            if (PlayerPrefs.HasKey(playerIdx) == false)
                isKeyEmpty =  true;

            numberOfPlayers++;
        }

        PlayerPrefs.SetString(playerIdx, PlayerData.playerName);
        PlayerPrefs.SetInt(numIdx.ToString(), PlayerData.playerScore);
        PlayerPrefs.Save();

    }

    public void ResetPlayerData()
    {
        PlayerData.playerScore = 0;
    }
}
