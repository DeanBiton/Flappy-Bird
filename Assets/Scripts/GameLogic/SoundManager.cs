using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource dieAudio;
    private AudioSource hitAudio; 
    private AudioSource jumpAudio; 
    private AudioSource pointAudio; 
    private AudioSource swooshingAudio; 
    private bool isGamestart;
    void Start()
    {
        dieAudio = transform.GetChild(0).gameObject.GetComponent<AudioSource>();
        hitAudio = transform.GetChild(1).gameObject.GetComponent<AudioSource>();
        jumpAudio = transform.GetChild(2).gameObject.GetComponent<AudioSource>();
        pointAudio = transform.GetChild(3).gameObject.GetComponent<AudioSource>();
        swooshingAudio = transform.GetChild(4).gameObject.GetComponent<AudioSource>();
    }

    public void jump()
    {
        jumpAudio.Play();
    }

    public void point()
    {
        if(isGamestart)
            pointAudio.Play();
    }

    public void gameReady()
    {
        isGamestart = false;
        swooshingAudio.Play();
    }

    public void gameStart()
    {
        isGamestart = true;
    }

    public void gameOver()
    {
        isGamestart = false;
        hitAudio.Play();
        dieAudio.Play();
    }
}
