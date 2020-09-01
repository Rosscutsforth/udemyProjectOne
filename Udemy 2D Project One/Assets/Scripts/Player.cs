using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;
    private float input;

    Rigidbody2D rb;
    Animator anim;

    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        //attaching players Rigidbody physics component to rb variable
        rb = GetComponent<Rigidbody2D>();
        //getting the animator component from the player character
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //storing player input
        input = Input.GetAxisRaw("Horizontal");

        //moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
