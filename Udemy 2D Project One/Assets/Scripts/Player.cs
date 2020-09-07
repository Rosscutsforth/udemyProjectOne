using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameObject losePanel;

    public Text healthDisplay;

    public float speed = 10f;
    private float input;

    Rigidbody2D rb;
    Animator anim;
    AudioSource source;

    public int health = 3;

    public float startDashTime;
    private float dashTime;
    public float extraSpeed;
    private bool isDashing;

    // Start is called before the first frame update
    void Start()
    {
        //attaching audio source to AudioSource component
        source = GetComponent<AudioSource>();
        //attaching players Rigidbody physics component to rb variable
        rb = GetComponent<Rigidbody2D>();
        //getting the animator component from the player character
        anim = GetComponent<Animator>();

        healthDisplay.text = health.ToString();
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

        if (Input.GetKeyDown(KeyCode.Space) && isDashing == false)
        {
            speed += extraSpeed;
            isDashing = true;
            dashTime = startDashTime;
        }

        if (dashTime <= 0 && isDashing == true)
        {
            isDashing = false;
            speed -= extraSpeed;
        }
        else
        {
            dashTime -= Time.deltaTime;
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
        source.Play();
        health -= damageAmount;
        if (health < 0)
        {
            healthDisplay.text = 0.ToString();
        }
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            losePanel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
