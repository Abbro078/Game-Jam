using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ClosetController : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;
    public SafeController safeController;
    public Animator coloredAnimator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
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

        if (safeController != null && safeController.isOpen)
        {
            safeController.Close();
        }
    }
}
