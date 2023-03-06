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
        PlayerMove();
    }

    void PlayerMove()
    {
        Vector2 input = playerInput.actions["Move"].ReadValue<Vector2>();
        moveDirection = new Vector3(input.x, 0, input.y);

        transform.position += moveDirection * speed * Time.deltaTime;

        if (moveDirection != Vector3.zero)
        {
            playerTransform.rotation = Quaternion.LookRotation(moveDirection);
        }
    }

    public void OnFire()
    {
        // UI Click 를 통한 Event 는 EventSystem
        // 미사일 발사
        Debug.Log("Click Fire");
    }

   
}
