using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject bulletInfo;
    

    private void Awake()
    {
        initialize();
    }
    void Start()
    {
        
    }

    public void initialize()
    {
        // DontDestroyOnLoad(this.gameObject);
        // PlaySetting();
    }

    public void PlaySetting()
    {
        // Plan ���� UI, Player�� ��� Instantiate
        // Resources Load(Prefabs)
    }
}


