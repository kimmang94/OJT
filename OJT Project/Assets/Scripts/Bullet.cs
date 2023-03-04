using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Weapon
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
