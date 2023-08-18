using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float life = 100, score, scoreBoss;
    public GameObject explosionAnimation;

	void Update ()
    {
        Dead();
	}

    void Dead()
    {
        if (life <= 0)
        {
            GameManager.Instance.score += score;
            GameManager.Instance.scoreBoss += scoreBoss;
            Instantiate(explosionAnimation, transform.position, transform.rotation);
            gameObject.SetActive(false);
           
            
        }
        
    }
}
