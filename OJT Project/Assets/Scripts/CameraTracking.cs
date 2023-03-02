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
        // Player 이동후 쿼터뷰에 맞게 위치 조정
        PlayerTransformTracking();
    }

    public void PlayerTransformTracking()
    {
        // Player Rotate 변화에 따라 조절
        
    }
}
