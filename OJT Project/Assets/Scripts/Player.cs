using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector3 moveDirection;
    float moveSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        if (input != null)
        {
            moveDirection = new Vector3(input.x, 0f, input.y);
        }
    }

    public void PlayerMove()
    {
        // Player 이동 InputSystem 
        bool hasControl = (moveDirection != Vector3.zero);
        if (hasControl)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection);
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        // Animation 추가하면 이동에 맞게 이동
    }
}
