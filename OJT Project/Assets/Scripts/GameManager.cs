using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Wood woods;

    private void Awake()
    {
        initialize();
    }
    void Start()
    {
        
    }

    public void initialize()
    {
        DontDestroyOnLoad(this.gameObject);
        PlayAssetsSetting();
    }

    public void PlayAssetsSetting()
    {
        // Plan 제외 UI, Player등 요소 Instantiate
        GameObject instanceEnemysObject = Instantiate(Resources.Load<GameObject>("Prefabs/Enemys"));
        GameObject instancePlayerObject = Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
        GameObject instanceUI = Instantiate(Resources.Load<GameObject>("Prefabs/UI"));
        GameObject instanceWoodsObject = Instantiate(Resources.Load<GameObject>("Prefabs/Woods"));
    }
}


