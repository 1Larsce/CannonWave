using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunProjectile : MonoBehaviour
{
    public float life = 20f;
    public float stunDuration = 2f; 

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StunEnemy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    void StunEnemy(GameObject enemy)
    {
        enemy.GetComponent<EnemyMovement>().Stun(stunDuration);
    }
}
