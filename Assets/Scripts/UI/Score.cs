using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    void Start() 
    {
        score = 0;
    }

    void Update() 
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}

//endScreen.GetComponent<Transform>().transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();