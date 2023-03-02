using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreateBullet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateBullet()
    {
        // Bullet 10개 미리생성 ObjectPool 로 관리
    }

    public void PlaneSearch()
    {
        // Ray 를 하단으로 쏴서 Plan있는지 없는지 확인
    }
}
