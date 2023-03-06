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
        // ���� ray�� ��� �ִ� ��ü 

        // ���� ��ü�� plane �̸� �����������
    }
}
