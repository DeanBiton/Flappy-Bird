using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject prefabPlayer;
    [SerializeField] private GameObject environment;
    [SerializeField] private GameObject canvas;

    private GameObject player;
    private bool isGameReady;

    void Start()
    {
        canvas.GetComponent<MainUI>().setChildren();
        gameReady();
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGameReady)
        {
            isGameReady = false;
            gameStart();
        }
    }

    public void gameReady()
    {
        isGameReady = true;
        Time.timeScale = 1;
        if(player != null)
            Destroy(player);
        Score.score = 0;
        player = Instantiate(prefabPlayer);
        player.GetComponent<Player>().gameReady();
        environment.GetComponent<GeneratePipes>().gameReady();
        canvas.GetComponent<MainUI>().gameReady();
    }

    public void gameStart()
    {
        player.GetComponent<Player>().gameStart();
        environment.GetComponent<GeneratePipes>().gameStart();
        canvas.GetComponent<MainUI>().gameStart();
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        environment.GetComponent<GeneratePipes>().gameOver();
        canvas.GetComponent<MainUI>().gameOver();
    }

    public void menuBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
