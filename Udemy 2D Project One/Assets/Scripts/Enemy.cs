using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float minSpeed = 12f;
    public float maxSpeed = 18f;

    float speed;

    Player playerScript;

    public int damage = 1;

    void Start()
    {
        speed = UnityEngine.Random.Range(minSpeed, maxSpeed);
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.tag == "Player")
        {
            playerScript.TakeDamage(damage);
        }
    }

}
