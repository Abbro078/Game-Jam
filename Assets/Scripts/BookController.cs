using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;

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
        isOpen = true;
    }

    void Close()
    {
        animator.SetTrigger("close");
        isOpen = false;
    }
}
