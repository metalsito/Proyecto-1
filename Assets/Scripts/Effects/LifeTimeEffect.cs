using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeEffect : MonoBehaviour {

    public float timer;
	void Update ()
    {
        Dead();
	}

    void Dead()
    {
        timer += Time.deltaTime;
        if (timer >= 1.85f)
            Destroy(gameObject);
    }
}
