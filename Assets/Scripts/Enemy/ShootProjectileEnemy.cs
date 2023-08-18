using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectileEnemy : MonoBehaviour
{
    public GameObject laser, missile, missileBay1, missileBay2, laserCanon1, laserCanon2;
    public float timer, timer2;

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        timer += Time.deltaTime;
        if (timer >= 3.45f)
        {
            Instantiate(missile, missileBay1.transform.position, missileBay1.transform.rotation);
            Instantiate(missile, missileBay2.transform.position, missileBay2.transform.rotation);
            timer = 0;
        }

        timer2 += Time.deltaTime;
        if (timer2 >= 1.25f)
        {
            Instantiate(laser, laserCanon1.transform.position, laserCanon1.transform.rotation);
            Instantiate(laser, laserCanon2.transform.position, laserCanon2.transform.rotation);
            timer2 = 0;
        }
    }
}
