using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private GameObject []lines;
    private int scoresNumber = 5;
    void Start()
    {
        this.loadScores();
        lines = new GameObject[scoresNumber];
        for (int i = 0; i < scoresNumber; i++)
        {
            lines[i] = transform.GetChild(0).GetChild(1).GetChild(1).GetChild(i).gameObject;
        }
    }

    public void showTopScores()
    {
        for (int i = 0; i < scoresNumber; i++)
        {
            lines[i].transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Text>().text = Score.topScoresDates[i];
            lines[i].transform.GetChild(1).gameObject.GetComponent<UnityEngine.UI.Text>().text = Score.topScores[i].ToString();
        }
    }

    public void loadScores()
    {
        for(int i = 0; i < 5; i++)
        {
            Score.topScores[i] = PlayerPrefs.GetInt("score" + i);
            Score.topScoresDates[i] = PlayerPrefs.GetString("date" + i) == "" ? "---" : PlayerPrefs.GetString("date" + i);
        }
    }
}
