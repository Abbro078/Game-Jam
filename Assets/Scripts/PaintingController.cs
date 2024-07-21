using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingController : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;
    public Animator coloredAnimator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if(GameManager.collectedCount == 5)
        {
            if (!isOpen)
            {
                OpenWithLetter();
            }
            else
            {
                CloseWithLetter();
            }
        }
        else
        {
            if (!isOpen)
            {
                Open();
            }
            else
            {
                Close();
            }
        }
        
    }


    private void OpenWithLetter()
    {
        animator.SetTrigger("openLetter");
        coloredAnimator.SetTrigger("openLetter");
        isOpen = true;
    }

    private void CloseWithLetter()
    {
        animator.SetTrigger("closeLetter");
        coloredAnimator.SetTrigger("closeLetter");
        isOpen = false;
    }

    void Open()
    {
        animator.SetTrigger("open");
        coloredAnimator.SetTrigger("open");
        isOpen = true;
    }

    void Close()
    {
        animator.SetTrigger("close");
        coloredAnimator.SetTrigger("close");
        isOpen = false;
    }
}
