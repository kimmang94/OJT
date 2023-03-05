using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Transform playerTransform; // 주인공 캐릭터의 Transform 컴포넌트
    public float speed = 5f; // Pet 오브젝트의 이동 속도

    void FixedUpdate()
    {
        // 주인공 캐릭터의 위치를 따라가기
        Vector3 targetPosition = new Vector3(playerTransform.position.x, transform.position.y, playerTransform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // 주인공 캐릭터 쪽으로 회전하기
        transform.LookAt(playerTransform);
    }
}
