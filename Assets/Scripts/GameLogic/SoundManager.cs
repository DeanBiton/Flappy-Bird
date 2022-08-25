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
        pointAudio.Play();
    }

    public void gameReady()
    {
        swooshingAudio.Play();
    }

    public void gameOver()
    {
        hitAudio.Play();
        dieAudio.Play();
    }
}
