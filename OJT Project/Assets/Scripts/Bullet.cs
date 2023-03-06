using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    Rigidbody rigid;

    private float bulletSpeed = 100;


    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Attack()
    {
        rigid.AddForce(Vector3.forward * bulletSpeed * Time.deltaTime);
    }
    void currentRayCastHitInfo()
    {
        // 현재 ray에 닿고 있는 객체 

        // 만약 객체가 plane 이면 사라지지않음
    }
}
