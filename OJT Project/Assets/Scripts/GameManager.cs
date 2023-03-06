using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private Bullet bullet;
    [SerializeField] private Player player;
    private void Awake()
    {
        SettingPrefabs();
    }

    void SettingPrefabs()
    {
        Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/Pet") );
        //Instantiate(Resources.Load<GameObject>("Prefabs/Enemys"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/Wood"));
        Instantiate(Resources.Load<GameObject>("Prefabs/UI"));
    }

    void BulletCount()
    {

    }

}
