using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePlayerCollision : MonoBehaviour
{
    public float damage = 25;
    public GameObject explosionAnimation;

    private void OnTriggerEnter(Collider other)
    {
        EnemyStats enemyLife = other.gameObject.GetComponent<EnemyStats>();
        if (other.gameObject.tag == "Enemy")
        {
            enemyLife.life -= damage;
            Instantiate(explosionAnimation, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
