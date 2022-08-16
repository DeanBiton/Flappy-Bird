using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce = 0;
    [SerializeField] private float velocity = 0;
    private Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //before build change to Input.GetMouseButtonDown(0)
        {
            rigidbody.velocity = Vector3.up * velocity;
            // rigidbody.velocity = Vector2.zero;
            // rigidbody.AddForce(jumpForce*Vector3.up);
        }
    }
}
