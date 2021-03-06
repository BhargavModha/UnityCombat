using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{

    public GameObject pauseScreen;
    public GameObject gameUIScreen;
    public GameObject lostScreen;
    public GameObject winScreen;

    bool paused;

    void Start()
    {
        paused = true;
        Time.timeScale = 0f; 
        Cursor.visible = true;

        pauseScreen.SetActive(true);
        gameUIScreen.SetActive(false);
        lostScreen.SetActive(false);
        winScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused == false)
            {
                PauseGame();
            }
            else
            {
                ContinueGame();
            }
        }
    }

    public void PauseGame()
    {
        paused = true;
        Time.timeScale = 0f;
        Cursor.visible = true;

        pauseScreen.SetActive(true);
        gameUIScreen.SetActive(false);
    }

    public void ContinueGame()
    {
        paused = false;
        Time.timeScale = 1f;
        Cursor.visible = false;

        pauseScreen.SetActive(false);
        gameUIScreen.SetActive(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void WinLevel()
    {
        paused = true;
        Time.timeScale = 0f;
        Cursor.visible = true;

        pauseScreen.SetActive(false);
        gameUIScreen.SetActive(false);
        winScreen.SetActive(true);
    }

    public void LostLevel()
    {
        paused = true;
        Time.timeScale = 0f;
        Cursor.visible = true;

        pauseScreen.SetActive(false);
        gameUIScreen.SetActive(false);
        lostScreen.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
