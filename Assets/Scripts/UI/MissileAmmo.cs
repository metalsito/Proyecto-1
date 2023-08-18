using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileAmmo : MonoBehaviour
{
    public Text missileAmmo;
    StatsPlayer missileAmmunition;

	// Use this for initialization
	void Start ()
    {
        missileAmmunition = FindObjectOfType<StatsPlayer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (missileAmmunition == null) return;

        missileAmmo.text = missileAmmunition.missileAmmo.ToString() + "/10 Missiles";
	}
}
