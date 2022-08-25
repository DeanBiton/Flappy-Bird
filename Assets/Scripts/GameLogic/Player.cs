using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float velocity = 0;
    
    public SoundManager soundManager;

    private GameManager gameManager;
    private Rigidbody2D rigidbody;
    private Vector3 playerStartPosition;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerStartPosition = new Vector3(-9.5f,1f,75f);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = Vector3.up * velocity;
            soundManager.jump();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name != "ceiling")
            gameManager.gameOver();
    }

    public void gameReady()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public void gameStart()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
    }
}
