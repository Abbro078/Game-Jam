using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private bool isActive = true;

    void OnMouseDown()
    {
        ToggleFlashlight();
    }

    void ToggleFlashlight()
    {
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }
}
