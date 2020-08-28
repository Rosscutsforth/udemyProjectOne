using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAndCold : MonoBehaviour
{

    int randomNumber;
    [Range(0, 100)]
    public int guess;

    int numberOfAttempts;

    // Start is called before the first frame update
    void Start()
    {
        randomNumber = UnityEngine.Random.Range(0, 101);

        print("Welcome to the Hot & Cold guessing game.");
        print("A random number has been chosen between 0 & 100. Your goal is to find this number in the fewest attempts.");
        print("Enter in your guess and then press space to submit it. Good luck!");
    }

    // Update is called once per frame
    void Update()
    {

        int difference = Mathf.Abs(randomNumber - guess);

        if (Input.GetKeyDown("space"))
        {
            numberOfAttempts += 1;

            if (guess == randomNumber)
            {
                print("Congratulations! You won, it took you " + numberOfAttempts.ToString() + " attempts!");
            }
            else if (difference <= 5)
            {
                print("Super NOVAAAAAA");
            }
            else if (difference <= 10)
            {
                print("Very Hot Hot Tamale!!");
            }
            else if (difference <= 20)
            {
                print("You getting hotter BROTHER");
            }
            else if (difference <= 30)
            {
                print("Kinda hot, kinda cold; like American dragon Jake Long");
            }
            else if (difference <= 50)
            {
                print("Pretty cold tbh");
            }
            else if (difference > 50)
            {
                print("Your guess was incredibly incorrect");
            }
        }
    }
}
