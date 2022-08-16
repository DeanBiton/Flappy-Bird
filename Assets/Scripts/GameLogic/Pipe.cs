using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    void Start() {}

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x < -35f)
            Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Score.score++;
    }
}
