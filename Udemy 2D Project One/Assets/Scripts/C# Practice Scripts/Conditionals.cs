using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    public int health = 5;

    public string playerName = "Jerome";

    // Start is called before the first frame update
    void Start()
    {
        if (health <= 0)
        {
            print("You are dead");
        }
        else
        {
            print("You're still alive!");
        }

        if (playerName.Length <= 3)
        {
            print("Your name is tiny bro!");
        }
        else if (playerName.Length <= 6)
        {
            print("Your name is pretty average I guess");
        }
        else
        {
            print("Daaaaamn you have a long ass name!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
