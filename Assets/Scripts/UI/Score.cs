using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore;
    public static int[] topScores = Enumerable.Repeat(0, 5).ToArray();
    public static string[] topScoresDates = Enumerable.Repeat("---", 5).ToArray();
    
    [SerializeField] private GameObject canvas;

    void Start() 
    {
        score = 0;
        this.load();
    }

    void Update() 
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
    
    public void gameOver()
    {
        string currentDate = DateTime.UtcNow.ToString("dd-MM-yyyy");
        bool save = false;

        if(score > topScores[4])
        {
            topScores[4] = score;
            topScoresDates[4] = currentDate;
            save = true;
        }

        for(int i = 3 ; i >= 0; i--)
        {
            if(score > topScores[i])
            {
                topScores[i+1] = topScores[i];
                topScores[i] = score;
                topScoresDates[i+1] = topScoresDates[i];
                topScoresDates[i] = currentDate;

                if(i == 0)
                {
                    bestScore = score;
                    PlayerPrefs.SetInt("bestScore", bestScore);
                    canvas.GetComponent<MainUI>().newBestScore();
                }
            }
        }

        if(save)
            this.save(); 
    }

    private void save()
    {
        for(int i = 0; i < 5; i++)
        {
            PlayerPrefs.SetInt("score" + i, topScores[i]);
            PlayerPrefs.SetString("date" + i, topScoresDates[i]);
        }
    }

    public void load()
    {
        for(int i = 0; i < 5; i++)
        {
            topScores[i] = PlayerPrefs.GetInt("score" + i);
            topScoresDates[i] = PlayerPrefs.GetString("date" + i) == "" ? "---" : PlayerPrefs.GetString("date" + i);
        }
        bestScore = topScores[0];
    }

}