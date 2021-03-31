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
        Cursor.visible = true;
        //myCam.GetComponent<CamTime>().StopCam();
        //Time.timeScale = 0f;
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
        //myCam.GetComponent<CamTime>().StopCam();
        //Time.timeScale = 0f;
        Cursor.visible = true;
        pauseScreen.SetActive(true);
    }

    public void ContinueGame()
    {
        paused = false;
        Cursor.visible = false;
        //myCam.GetComponent<CamTime>().StartCam();
        //Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
