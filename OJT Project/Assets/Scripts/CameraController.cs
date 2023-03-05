using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // 플레이어의 Transform을 저장할 변수
    public Vector3 offset; // 카메라의 위치 오프셋
    public float smoothing = 5.0f; // 카메라 이동 및 회전 스무딩 값

    private void LateUpdate()
    {
        // 카메라의 위치를 플레이어의 위치에 맞게 업데이트합니다.
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);

        // 카메라가 플레이어를 바라보도록 회전합니다.
        transform.LookAt(target);
    }
}
