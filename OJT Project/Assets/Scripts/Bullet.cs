using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    Transform bulletPosition;
    [SerializeField]
    ObjectPoolManager objectPoolManager;
    private void Start()
    {
        objectPoolManager = GetComponent<ObjectPoolManager>();
    }
    public void OnFire()
    {
        Debug.Log("OnFire");
        objectPoolManager.UsePool(bulletPosition.position);
    }
}
