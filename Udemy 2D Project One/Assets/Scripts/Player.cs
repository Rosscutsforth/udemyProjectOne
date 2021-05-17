using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public GameObject losePanel;

    public Text healthDisplay;
    public Text maxHealthDisplay;

    public float speed = 10f;
    private float input;

    Rigidbody2D rb;
    Animator anim;

    //Audio Variable Declarations
    AudioSource source;
    public AudioClip heal;
    public AudioClip hurt;

    //Spawner Variable Declarations
    private GameObject headSpawner;
    private Transform headSpawnerTransform;

    public GameObject flowerPower;

    //Health Variable Declarations
    public int health = 4;
    public int maxHealth = 4;

    //Jumping Variables
    private bool isGrounded = true;
    public int jumpForce = 15;
    public float groundCheckRadius;
    public Transform groundCheck;
    public LayerMask ground;
    private bool isJumping;


    //Dashing Variables
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
        //getting the particle head spawner's transform
        headSpawner = GameObject.Find("ParticleHeadSpawner");

        healthDisplay.text = health.ToString();
    }

    private void Update()
    {

        maxHealthDisplay.text = maxHealth.ToString();

        //Dashing and movement if statements

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

        if (Input.GetKeyDown(KeyCode.LeftShift) && isDashing == false)
        {
            speed += extraSpeed;
            isDashing = true;
            dashTime = startDashTime;
            anim.SetBool("isDashing", true);
            Object.Instantiate(flowerPower, headSpawner.transform.position, Quaternion.identity);
        }

        if (dashTime <= 0 && isDashing == true)
        {
            isDashing = false;
            speed -= extraSpeed;
            anim.SetBool("isDashing", false);
        }
        else
        {
            dashTime -= Time.deltaTime;
        }

        //makes player jump
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            isGrounded = false;
            anim.SetBool("isJumping", true);
            rb.velocity = Vector2.up * jumpForce;
        }

        if(isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //storing player input
        input = Input.GetAxisRaw("Horizontal");

        //moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);

        //checks for ground contact
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, ground);
    }

    public void TakeDamage(int damageAmount)
    {
        if(damageAmount == 1 || damageAmount == 2)
        {
            source.PlayOneShot(hurt, 1);
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
        else if(damageAmount == -1 && health < maxHealth)
        {
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

}
