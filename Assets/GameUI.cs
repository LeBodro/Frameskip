using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public GameObject JumpScare;
    public GameObject[] Lives;
    public Movement Player;
    public int LivesLeft = 3;
    public AudioSource Scream;
    public GameController gc;
    public Text Score;

    void Start()
    {
        for (int i = Lives.Length - 1; i >= LivesLeft; i--)
            Lives[i].SetActive(false);

        Player.OnDeath += TriggerPlayerDeath;
        if (gc != null) gc.OnWin += RefreshScore;
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

    void RefreshScore(int value)
    {
        Score.text = value.ToString();
    }
}
