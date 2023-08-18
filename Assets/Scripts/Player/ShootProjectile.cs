using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject laser, missile, laserCanon1, laserCanon2, missileBay1, missileBay2;
    public float timer,timer2;

    void Update ()
    {
        Shoot();
	}

    void Shoot()
    {
        StatsPlayer missileAmmunition = gameObject.GetComponent<StatsPlayer>();
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.B) && timer >= 1.45f && missileAmmunition.missileAmmo > 0)
        {
            Instantiate(missile, missileBay1.transform.position, missileBay1.transform.rotation);
            Instantiate(missile, missileBay2.transform.position, missileBay2.transform.rotation);
            missileAmmunition.missileAmmo -= 2;
            timer = 0;
        }

        timer2 += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && timer2 >= 0.45f)
        {
            Instantiate(laser, laserCanon1.transform.position, laserCanon1.transform.rotation);
            Instantiate(laser, laserCanon2.transform.position, laserCanon2.transform.rotation);
            timer2 = 0;
        }
    }
}
