using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifeTime : MonoBehaviour
{
    public float timer;
    public GameObject explosionAnimation;

    void Update ()
    {
        Dead();
	}

    void Dead()
    {
        timer += Time.deltaTime;
        if(timer >= 5)
        {
            Instantiate(explosionAnimation, transform.position, transform.rotation);
            Destroy(gameObject);
            timer = 0;
        }
    }
}
