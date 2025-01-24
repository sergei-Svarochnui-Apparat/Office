using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControll : MonoBehaviour
{
    private Vector2 XYRotation;
    [SerializeField] private Transform PlayerCamera;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }

    void Update()
    {
        Vector2 MoveInput = new Vector2
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };
        XYRotation.x -= MoveInput.y;
        XYRotation.y += MoveInput.x;
        transform.eulerAngles = new Vector3(0, XYRotation.y, 0);
        PlayerCamera.localEulerAngles = new Vector3(XYRotation.x, 0, 0);
    }
}
