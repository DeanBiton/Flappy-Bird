using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update() {}

    public void gameOver()
    {
        Time.timeScale = 0;
    }
}
