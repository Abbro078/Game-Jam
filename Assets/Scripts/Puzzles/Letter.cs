using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    private bool isActive = true;
    //public GameObject coloredFlashlight;

    void OnMouseDown()
    {
        ToggleFlashlight();
    }

    void ToggleFlashlight()
    {
        GameManager.collectedCount++;
        isActive = !isActive;
        gameObject.SetActive(isActive);
        //coloredFlashlight.gameObject.SetActive(isActive);
    }
}
