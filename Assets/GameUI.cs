﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public GameObject JumpScare;
    public GameObject[] Lives;
    public Movement Player;
    public int LivesLeft = 3;
    public AudioSource Scream;

    void Start()
    {
        for (int i = Lives.Length - 1; i >= LivesLeft; i--)
            Lives[i].SetActive(false);

        Player.OnDeath += TriggerPlayerDeath;
    }

    void TriggerPlayerDeath()
    {
        LivesLeft--;
        Lives[LivesLeft].SetActive(false);
        StartCoroutine(DoJumpScare());
    }

    IEnumerator DoJumpScare()
    {
        JumpScare.SetActive(true);
        Scream.Play();
        yield return new WaitForSecondsRealtime(0.37f);
        JumpScare.SetActive(false);
        if (LivesLeft == 0)
            ResetGame();
    }

    void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
