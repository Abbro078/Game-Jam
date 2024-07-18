using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;

    [SerializeField] 
    private CinemachineVirtualCamera[] allVirtualCameras;
    private CinemachineFramingTransposer framingTransposer;
    private int current = 0;

    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
        }

        for (int i = 0; i < allVirtualCameras.Length ; i++)
        {
            if(allVirtualCameras[i].enabled)
            {
                framingTransposer = allVirtualCameras[i].GetCinemachineComponent<CinemachineFramingTransposer>();
                Debug.Log(allVirtualCameras[i]);
            }
        }
        Debug.Log("Aya<3");
    }

    private void Start() {
        current = 0;
    }

    public void SwapCameraRight()
    {
        Debug.Log(current);
        if(current == 3)
        {
            allVirtualCameras[0].enabled = true;
            allVirtualCameras[current].enabled = false;
            current = 0;
            framingTransposer = allVirtualCameras[current].GetCinemachineComponent<CinemachineFramingTransposer>();
        }
        else
        {
            allVirtualCameras[current+1].enabled = true;
            allVirtualCameras[current].enabled = false;
            current++;
            framingTransposer = allVirtualCameras[current].GetCinemachineComponent<CinemachineFramingTransposer>();
        }
        Debug.Log("After"+current);
    }

    public void SwapCameraLeft()
    {
        Debug.Log(current);
        if(current == 0)
        {
            allVirtualCameras[3].enabled = true;
            Debug.Log(allVirtualCameras[3]);
            allVirtualCameras[current].enabled = false;
            current = 3;
            framingTransposer = allVirtualCameras[current].GetCinemachineComponent<CinemachineFramingTransposer>();
        
        }
        else
        {
            allVirtualCameras[current-1].enabled = true;
            allVirtualCameras[current].enabled = false;
            current--;
            framingTransposer = allVirtualCameras[current].GetCinemachineComponent<CinemachineFramingTransposer>();
        }
        Debug.Log("After"+current);
    }
}