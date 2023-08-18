using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemyCollision : MonoBehaviour
{
    public float damage = 50;
    public GameObject explosionAnimation;

    private void OnTriggerEnter(Collider other)
    {
        StatsPlayer playerLife = other.gameObject.GetComponent<StatsPlayer>();
        if (other.gameObject.tag == "Player")
        {
            playerLife.life -= damage;
            Instantiate(explosionAnimation, transform.position, transform.rotation);
            Destroy(gameObject);
        }
            
    }
}
