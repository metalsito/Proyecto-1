using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float score, scoreBoss;
    public bool deadPlayer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Update ()
    {
        Conditions();
	}

    void Conditions()
    {
        if (score >= 6)
            Win();

        if (deadPlayer == true)
            Lose();

        if (scoreBoss >= 1)
            WinBoss();
    }
    void Win()
    {
        Delete();
        SceneManager.LoadScene("BossFight");
    }
    void Lose()
    {
        Delete();
        SceneManager.LoadScene("LoserScene");
    }
    void Delete()
    {
        score = 0;
        scoreBoss = 0;
        deadPlayer = false;
    }
    void WinBoss()
    {
        Delete();
        SceneManager.LoadScene("WinnerScene");
    }
}
