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
        // �Ѿ˰� �¾Ҵ��� Ȯ��
        if (false)
        {
            DestroyEnemy();
        }
        
    }

    public void DestroyEnemy()
    {
        // �浹 Ȯ���� ���� ����
        StartCoroutine(DestroyAfterFiveSecound());
    }

    IEnumerator DestroyAfterFiveSecound()
    {
        yield return new WaitForSeconds(5f);
        Destroy(this.gameObject);
    }
}
