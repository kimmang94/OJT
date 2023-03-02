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
        // Plan 제외 UI, Player등 요소 Instantiate
        // Resources Load(Prefabs)
    }
}


