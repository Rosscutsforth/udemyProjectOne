using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    public string name = "Ross";
    public string weapon = "Wooden Sword";
    public int health = 10;
    public float speed = 5.5f;
    public int enemyDamage = 2;

    // Start is called before the first frame update
    void Start()
    {
        print("Welcome " + name);
        print("The enemy found you and you were too slow to escape because your speed is " + speed.ToString());

        health -= enemyDamage;

        print("The enemy dealt you " + enemyDamage.ToString() + " damage so you have " + health.ToString() + " health left");
        print("A mighty battle ensued in which you were able to deal a finishing blow to the enemy with your " + weapon);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
