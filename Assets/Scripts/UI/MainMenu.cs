using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private GameObject menu;
    private GameObject scoreboard;

    void Start()
    {
        menu = transform.GetChild(0).GetChild(0).gameObject;
        scoreboard = transform.GetChild(0).GetChild(1).gameObject;
    }

    public void playBtn()
    {
        SceneManager.LoadScene("Main");
    }

    public void menuBtn()
    {
        menu.SetActive(true);
        scoreboard.SetActive(false);
    }

    public void scoreboardBtn()
    {
        transform.GetComponent<ScoreBoard>().showTopScores();
        menu.SetActive(false);
        scoreboard.SetActive(true);
    }
}
