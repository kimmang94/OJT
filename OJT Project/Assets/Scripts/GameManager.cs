using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    Bullet bulletPrefab;

    private static GameManager instance;
    private void Awake()
    {
        InstanceNullCheck();
        SettingPrefabs();

    }
    private void Update()
    {

    }
    void InstanceNullCheck()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void SettingPrefabs()
    {
        Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/Pet"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/Enemys"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/Wood"));
        Instantiate(Resources.Load<GameObject>("Prefabs/UI"));
    }

    void BulletCount()
    {

    }
}
