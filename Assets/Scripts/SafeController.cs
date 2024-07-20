using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeController : MonoBehaviour
{
    private Animator animator;
    public bool isOpen { get; private set; } = false;

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

    public void Open()
    {
        animator.SetTrigger("open");
        isOpen = true;
    }

    public void Close()
    {
        animator.SetTrigger("close");
        isOpen = false;
    }
}
