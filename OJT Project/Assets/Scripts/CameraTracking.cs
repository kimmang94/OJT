using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    Transform PlayerTransform;
    Player playerInfo;
    void LateUpdate()
    {
        // Player �̵��� ���ͺ信 �°� ��ġ ����
    }

    public void PlayerTransformTracking()
    {
        this.gameObject.transform.position += playerInfo.transform.position;
        
    }
}
