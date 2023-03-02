using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    void Update()
    {
        HitAttack();
    }

    public void HitAttack()
    {
        // 총알과 맞았는지 확인
        if (false)
        {
            DestroyEnemy();
        }
        
    }

    public void DestroyEnemy()
    {
        // 충돌 확인후 본인 제거
        StartCoroutine(DestroyAfterFiveSecound());
    }

    IEnumerator DestroyAfterFiveSecound()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}
