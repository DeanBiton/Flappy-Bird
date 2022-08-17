using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    private GameObject score;
    private GameObject readyScreen;
    private GameObject endScreen;
    [SerializeField] private GameObject finalScoreTxt;
    [SerializeField] private GameObject bestScoreTxt;

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void setChildren()
    {
        score = transform.GetChild(0).gameObject;
        readyScreen = transform.GetChild(1).gameObject;
        endScreen = transform.GetChild(2).gameObject;
    }

    public void gameReady()
    {
        score.SetActive(false);
        readyScreen.SetActive(false);
        endScreen.SetActive(true);

    }

    public void gameStart()
    {
        score.SetActive(true);
        readyScreen.SetActive(false);
        endScreen.SetActive(false);
    }

    public void gameOver()
    {
        score.SetActive(false);
        readyScreen.SetActive(true);
        endScreen.SetActive(false);
        finalScoreTxt.GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
    }
}
