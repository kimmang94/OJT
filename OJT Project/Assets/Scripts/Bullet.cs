using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Weapon
{
    #region [const]
    const int MAXBULLET = 10;
    const int MINBULLET = 0;
    #endregion

    int currentBullet = 0;


    private void OnEnable()
    {
        CreateBullet();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBullet()
    {
        // Bullet 10�� �̸����� ObjectPool �� ����
    }

    public void ObjectPoolingBullet()
    {

    }

    public void PlaneSearch()
    {
        // Ray �� �ϴ����� ���� Plan�ִ��� ������ Ȯ��
    }

    public void BulletCount()
    {
        // Fire �� currentBullet --;
    }
}
