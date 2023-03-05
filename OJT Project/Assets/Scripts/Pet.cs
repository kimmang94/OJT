using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Transform playerTransform; // ���ΰ� ĳ������ Transform ������Ʈ
    public float speed = 5f; // Pet ������Ʈ�� �̵� �ӵ�

    void FixedUpdate()
    {
        // ���ΰ� ĳ������ ��ġ�� ���󰡱�
        Vector3 targetPosition = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // ���ΰ� ĳ���� ������ ȸ���ϱ�
        transform.LookAt(playerTransform);
    }
}
