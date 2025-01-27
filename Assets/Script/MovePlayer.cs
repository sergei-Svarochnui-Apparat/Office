using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float MoveSpeed = 0f;
    public float jumpHeight = 0f;
    public float Gravity = -9.8f; //постоянная величина
    private float ySpeed = 0f; // Вертикальная скорость

    private CharacterController characterController; //управление через контроллер
    private Vector3 velocity;

    private bool isGrounded;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        // Проверка, находится ли персонаж на земле
        isGrounded = characterController.isGrounded;

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        if (isGrounded && ySpeed < 0)
        {
            ySpeed = -2f; //персонаж не зависал в воздухе
        }
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            ySpeed = Mathf.Sqrt(jumpHeight * -2f * Gravity); // Формула для прыжка
        }

        ySpeed += Gravity * Time.deltaTime; // Применяем гравитацию

        velocity = new Vector3(move.x, ySpeed, move.z);

        // Двигаем персонажа
        characterController.Move(velocity * MoveSpeed * Time.deltaTime);
    }
}
