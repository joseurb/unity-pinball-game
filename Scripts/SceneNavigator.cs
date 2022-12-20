using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
   
    public GameObject menuOverlay;
    public static bool isGameOver = false;
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
        if (Time.timeScale == 0f)
            Time.timeScale = 1f;
        isGameOver = false;
    }

    public void PauseResume()
    {
        if (Input.GetKeyDown("escape") && SceneManager.GetActiveScene().name == "Game" && isGameOver == false)
        {
            if (Time.timeScale == 1f)
            {
                menuOverlay.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                menuOverlay.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }

    public void Resume()
    {
        menuOverlay.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You Quit The Game");
    }

    void Update()
    {
        PauseResume();
    }
}
