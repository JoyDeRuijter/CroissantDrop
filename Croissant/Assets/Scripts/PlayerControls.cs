using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, -2);
        if (Input.GetMouseButton(0))
        {
            rb.velocity = new Vector2(-4, rb.velocity.y);
        }
        else if (Input.GetMouseButton(1))
        {
            rb.velocity = new Vector2(4, rb.velocity.y);
        }
    }
}
