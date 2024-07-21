using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class DrawerController : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;
    public Animator coloredAnimator;
    public GameObject MazeColored;
    public GameObject MazeBW;
    private bool isActive = false;

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

        isActive = !isActive;
        MazeBW.gameObject.SetActive(isActive);
        MazeColored.gameObject.SetActive(isActive);
    }

    void Close()
    {
        animator.SetTrigger("close");
        coloredAnimator.SetTrigger("close");
        isOpen = false;

        isActive = !isActive;
        MazeBW.gameObject.SetActive(isActive);
        MazeColored.gameObject.SetActive(isActive);

    }
}
