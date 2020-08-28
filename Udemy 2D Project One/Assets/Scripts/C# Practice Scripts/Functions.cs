using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

    public int health = 10;
    public int damageAmount;

    void TakeDamage(int damage)
    {
        health -= damage;
        print("Ouch! You took damage. Your health is now " + health);
    }

    bool IsDead()
    {
        if (health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            TakeDamage(damageAmount);
        }

        while (IsDead() == true)
        {
            print("You died:(");
        }
    }
}
