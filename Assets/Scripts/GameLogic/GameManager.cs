using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject environment;

    private bool isGameReady;

    void Start()
    {
        //mainUI = canvas.GetComponent<MainUI>();
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
        player.GetComponent<Rigidbody2D>().isKinematic = true;
        environment.GetComponent<GeneratePipes>().enabled = false;
        canvas.GetComponent<MainUI>().gameReady();
    }

    public void gameStart()
    {
        player.GetComponent<Rigidbody2D>().isKinematic = false;
        environment.GetComponent<GeneratePipes>().enabled = true;
        canvas.GetComponent<MainUI>().gameStart();
    }

    public void gameOver()
    {
        Time.timeScale = 0;
         if(canvas == null)
         {
            Debug.Log("canvas is the problem");
         }
        else if(canvas.GetComponent<MainUI>() == null)
        {
            Debug.Log("Here is the problem");
        }
        else
        {
            canvas.GetComponent<MainUI>().gameOver();
        }
    }
}
