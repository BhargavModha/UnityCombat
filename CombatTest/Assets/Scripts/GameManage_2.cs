using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;


public class GameManage_2 : MonoBehaviour
{
    public GameObject pauseScreen;
    //public GameObject myCam;
    bool paused;

    void Start()
    {
        paused = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        //myCam.GetComponent<CamTime>().StopCam();
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == false)
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

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
        //myCam.GetComponent<CamTime>().StopCam();
        Time.timeScale = 0f;
        //Cursor.visible = true;
        pauseScreen.SetActive(true);
    }

    public void ContinueGame()
    {
        paused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //myCam.GetComponent<CamTime>().StartCam();
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void Menu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
