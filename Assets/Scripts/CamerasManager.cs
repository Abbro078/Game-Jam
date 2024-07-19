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


    private void InitializeCameras()
    {
        for (int i = 0; i < allVirtualCameras.Length; i++)
        {
            allVirtualCameras[i].enabled = (i == 0);
        }
    }
    private void Awake() 
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        InitializeCameras();

        framingTransposer = allVirtualCameras[current].GetCinemachineComponent<CinemachineFramingTransposer>();
        
        Debug.Log("Awake");
    }

    private void Start() {
        current = 0;
    }

    public void SwapCameraRight()
    {
        Debug.Log("Current camera index before swap right: " + current);

        int next = (current + 1) % allVirtualCameras.Length;
        allVirtualCameras[next].enabled = true;
        allVirtualCameras[current].enabled = false;
        current = next;

        framingTransposer = allVirtualCameras[current].GetCinemachineComponent<CinemachineFramingTransposer>();
        Debug.Log("Current camera index after swap right: " + current);
    }

    public void SwapCameraLeft()
    {
        Debug.Log("Current camera index before swap left: " + current);

        int prev = (current - 1 + allVirtualCameras.Length) % allVirtualCameras.Length;
        allVirtualCameras[prev].enabled = true;
        allVirtualCameras[current].enabled = false;
        current = prev;

        framingTransposer = allVirtualCameras[current].GetCinemachineComponent<CinemachineFramingTransposer>();
        Debug.Log("Current camera index after swap left: " + current);
    }
}