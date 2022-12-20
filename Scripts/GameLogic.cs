using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLogic : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;

    public TextMeshProUGUI score;
    private int num = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.CompareTag("LowerBumper") || collision.gameObject.CompareTag("SmallBumper"))
        {
			num += 5;
            PlayerData.playerScore += 5;
        }

		if (collision.gameObject.CompareTag("UpperBumper"))
        {
            num += 10;
            PlayerData.playerScore += 10;
        }
        score.text = "Score: " + num.ToString();

    }


}
