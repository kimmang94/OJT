using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // �÷��̾��� Transform�� ������ ����
    public Vector3 offset; // ī�޶��� ��ġ ������
    public float smoothing = 5.0f; // ī�޶� �̵� �� ȸ�� ������ ��

    private void LateUpdate()
    {
        // ī�޶��� ��ġ�� �÷��̾��� ��ġ�� �°� ������Ʈ�մϴ�.
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);

        // ī�޶� �÷��̾ �ٶ󺸵��� ȸ���մϴ�.
        transform.LookAt(target);
    }
}
