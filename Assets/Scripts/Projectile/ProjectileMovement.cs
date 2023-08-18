using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float Speed = 25;

	void Update ()
    {
        Movement();
	}

    void Movement()
    {
        transform.Translate(0f, 0f, Speed * Time.deltaTime);
    }
}
