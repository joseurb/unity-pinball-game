using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject resumeButton;
    public GameObject gameOverMenu;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            gameOverText.SetActive(true);
            resumeButton.SetActive(false);
            Destroy(collision.gameObject);
            gameOverMenu.SetActive(true);
            SceneNavigator.isGameOver = true;
        }
    }
}
