using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int bestScore;
    [SerializeField] private GameObject canvas;

    void Start() 
    {
        score = 0;
        bestScore = PlayerPrefs.GetInt("bestScore", bestScore);
    }

    void Update() 
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
    
    public void gameOver()
    {
        if(score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("bestScore", bestScore);
            canvas.GetComponent<MainUI>().newBestScore();
        }
    }
}