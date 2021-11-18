using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seedling : MonoBehaviour
{

    [HideInInspector]
    public Transform stopPoint;

    public float speed = 3;
    public float stopTime = 1f;

    //animation variables
    Animator anim;
    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("spawning", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(stopPoint != null)
        {
            stopPoint = GameObject.FindGameObjectWithTag("SeedlingStop").GetComponent<Transform>();
        }

        if(stopTime > 0)
        {
            stopTime -= Time.deltaTime;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            // anim.SetBool("isMoving", true);
        }
        else
        {
            // anim.SetBool("isMoving", false);
        }
    }
}
