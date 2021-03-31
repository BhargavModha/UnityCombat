using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamTime : MonoBehaviour
{
    public CinemachineBrain myCam;
    // Start is called before the first frame update
    void Start()
    {
        //m_IgnoreTimeScale
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopCam()
    {
        myCam.m_IgnoreTimeScale = false;
    }

    public void StartCam()
    {
        myCam.m_IgnoreTimeScale = true;
    }
}
