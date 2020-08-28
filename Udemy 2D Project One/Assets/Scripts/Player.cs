using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //attaching players Rigidbody physics component to rb variable
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //storing player input
        float input = Input.GetAxisRaw("Horizontal");

        //moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}
