using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public void SwapCameraRight() 
    {
        CameraManager.instance.SwapCameraRight();
    }

    public void SwapCameraLeft() 
    {
        CameraManager.instance.SwapCameraLeft();
    }
}