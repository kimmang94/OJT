using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    Transform PlayerTransform;
    Player playerInfo;
    void LateUpdate()
    {
        // Player 이동후 쿼터뷰에 맞게 위치 조정
    }

    public void PlayerTransformTracking()
    {
        this.gameObject.transform.position += playerInfo.transform.position;
        
    }
}
