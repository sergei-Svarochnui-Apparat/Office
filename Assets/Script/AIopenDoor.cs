using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class AIopenDoor : MonoBehaviour
{

    public Door door;
    public Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        door.isOpen = true;
        if (door.isOpen == true)
        {
            animator.SetBool("IsOpen", true);
        }
        print("Триггер");
    }
    private void OnTriggerExit(Collider other)
    {

        //animator.SetBool("IsOpen", false);
        print("нету");
    }

}
