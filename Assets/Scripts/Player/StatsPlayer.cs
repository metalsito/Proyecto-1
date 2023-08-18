using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPlayer : MonoBehaviour
{
    public float life = 300, missileAmmo = 5;
    public GameObject explosionAnimation;
    void Update ()
    {
        Dead();
	}

    void Dead()
    {
        if (life <= 0)
        {
            Instantiate(explosionAnimation, transform.position, transform.rotation);
            GameManager.Instance.deadPlayer = true;
            Destroy(gameObject);
        }
    }
}
