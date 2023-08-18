using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePoints : MonoBehaviour
{
    public Text textoVida;
    StatsPlayer lifePlayer;

	// Use this for initialization
	void Start ()
    {
        lifePlayer = FindObjectOfType<StatsPlayer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (lifePlayer == null) return;

        textoVida.text = lifePlayer.life.ToString() + "/450 HP";
	}
}
