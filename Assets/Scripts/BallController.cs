using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody rb;
    bool started;
    bool gameOver;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        started = false;
        gameOver = false;
    }
    void Update()
    {
        if (!started)
        {
            if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
            {
                //Debug.Log("space was pressed");
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
            }

        }

        Debug.DrawRay(transform.position, Vector3.down, Color.red);
        
        if (! Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
            rb.velocity = new Vector3(0, -25f, 0);
        }
   

        if (Input.GetKeyDown(KeyCode.Space))
        {
            switchDirection();
        }
    }

    void switchDirection()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }

        else if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
}
