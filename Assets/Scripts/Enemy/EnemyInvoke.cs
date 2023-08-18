using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInvoke : MonoBehaviour
{
    public GameObject enemy;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("InvokeEnemy", 4, 5);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void InvokeEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
