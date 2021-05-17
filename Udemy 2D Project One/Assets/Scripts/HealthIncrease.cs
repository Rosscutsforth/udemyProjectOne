using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class HealthIncrease : MonoBehaviour
{

    public float minSpeed = 12f;
    public float maxSpeed = 18f;
    //public float sideAngle1 = -.2f;
    //public float sideAngle2 = .2f;

    //float sideAngle;
    float speed;

    Player playerScript;

    public int damage = -1;

    public GameObject explosion;
    public GameObject trail;

    void Start()
    {
        //sideAngle = UnityEngine.Random.Range(sideAngle1, sideAngle2);
        speed = UnityEngine.Random.Range(minSpeed, maxSpeed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        // Instantiate(trail, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject != null)
        {
            transform.Translate(Vector2.down/*(0, -1)*/ * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.tag == "Player")
        {
            playerScript.maxHealth++;
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (hitObject.tag == "Ground")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}