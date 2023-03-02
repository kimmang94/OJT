using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        initialize();
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        
    }
    

    public void initialize()
    {

    }

    public void PlaySetting()
    {
        // Plan 제외 UI, Player등 요소 Instantiate
    }
}


