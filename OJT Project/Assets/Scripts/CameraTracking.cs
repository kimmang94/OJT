using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    [SerializeField]
    Transform PlayerTransform;
    [SerializeField]
    Player playerInfo;
    void LateUpdate()
    {
        // Player �̵��� ���ͺ信 �°� ��ġ ����
        PlayerTransformTracking();
    }

    public void PlayerTransformTracking()
    {
        // Player Rotate ��ȭ�� ���� ����
        
    }
}
