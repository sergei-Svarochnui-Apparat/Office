using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public Animator animator;
    public bool isOpen;
    void Start()
    {
        if (isOpen)
        {
            animator.SetBool("IsOpen", true);
        }
    }
    public string GetDescripting()
    {
        if (isOpen) return "Press [E] to <color=red>close</color> the door";
        return "Press [E] to <color=green>close</color> the door";
    }
    public void Interact()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            animator.SetBool("IsOpen", true);
        }
        else
            animator.SetBool("IsOpen", false);
    }

}
