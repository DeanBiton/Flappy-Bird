using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameReady()
    {
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
    }

    public void gameStart()
    {
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
    }

    public void gameOver()
    {
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
