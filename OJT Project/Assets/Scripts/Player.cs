using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed = 3;

    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector2 nextVec = inputVec * speed * Time.deltaTime;
        Vector3 vec3next = new Vector3(nextVec.x, 0, nextVec.y);
        transform.LookAt(rigid.position + vec3next);
        rigid.MovePosition(rigid.position + vec3next);
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
