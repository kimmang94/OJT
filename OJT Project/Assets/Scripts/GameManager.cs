using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/Pet"));
       // Instantiate(Resources.Load<GameObject>("Prefabs/Enemys"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/Wood"));
        //Instantiate(Resources.Load<GameObject>("Prefabs/UI"));

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
