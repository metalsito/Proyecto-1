using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20;

	void Update ()
    {
        InputMovement();
	}

    void InputMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0f, 0f, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0f, 0f, -speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(speed * Time.deltaTime, 0f, 0f);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
    }
}
