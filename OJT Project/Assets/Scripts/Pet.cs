using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    Player playerTransform;
    Transform target;

    Vector3 direction;
    private void OnEnable()
    {
        playerTransform = GetComponent<Player>();
        GetPlayerTransform();
    }

    private void Update()
    {
        transform.LookAt(target);
    }
    void GetPlayerTransform()
    {
        target = playerTransform.transform;
        
    }

}
