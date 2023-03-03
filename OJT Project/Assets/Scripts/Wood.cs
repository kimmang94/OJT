using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField]
    Transform mainCameraTransform;
    private void OnEnable()
    {
        LookingCamera();
    }
    public void LookingCamera()
    {
        // Player & Camera �ٶ󺸱�
        mainCameraTransform = Camera.main.transform;
        mainCameraTransform.LookAt(mainCameraTransform.position);
        
    }

}
