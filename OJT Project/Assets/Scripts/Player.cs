using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
        public float speed = 10f;
        public GameObject missilePrefab;
        public Transform missileSpawn;

        private Vector2 moveInput;
        private Rigidbody rb;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void OnMove(InputValue value)
        {
            moveInput = value.Get<Vector2>();
        }

        public void OnFire()
        {
            Instantiate(missilePrefab, missileSpawn.position, missileSpawn.rotation);
        }

        private void FixedUpdate()
        {
            Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y);
            rb.AddForce(movement * speed);
        }
    
}
