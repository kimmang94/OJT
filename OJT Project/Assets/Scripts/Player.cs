using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    PlayerInput playerInput;
    float speed = 5;
    Vector3 moveDirection;
    Transform playerTransform;
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerTransform = transform;
    }

    private void Update()
    {
        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();
        moveDirection = new Vector3(input.x, 0, input.y);

        transform.position += moveDirection * speed * Time.deltaTime;

        if (moveDirection != Vector3.zero)
        {
            // 캐릭터가 이동하는 방향으로 회전합니다.
            playerTransform.rotation = Quaternion.LookRotation(moveDirection);
        }
    }
   
}
