using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool isHit = false;
    
    void Update()
    {
        
    }



    public void HitCheckAndDestroyEnemy()
    {
        if (isHit)
        {
            // 충돌 확인후 본인 제거
            StartCoroutine(DestroyAfterFiveSecound());
        }
    }

    IEnumerator DestroyAfterFiveSecound()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}
