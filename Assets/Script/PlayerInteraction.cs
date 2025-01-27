using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCamera;
    public float interactionDistance = 10f;

    public GameObject interactionUI;
    public GameObject interactionUINPC;
    public TextMeshProUGUI interactionText;
    public TextMeshProUGUI interactionTextNPC;


    void Update()
    {
        interactionRay();
    }

    void interactionRay()
    {
        Ray ray = mainCamera.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;
        bool hitSomething = false;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                hitSomething = true;
                interactionText.text = interactable.GetDescripting();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }
        interactionUI.SetActive(hitSomething);
    }
}
