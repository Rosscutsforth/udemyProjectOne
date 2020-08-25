using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberStringVariableChallenge : MonoBehaviour
{

    public string firstName = "Ross";
    public string lastName = "Cutsforth";
    public int birthYear = 1996;
    public int currentYear = 2020;

    System.Random rnd = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        string fullName = firstName + lastName;
        int age = currentYear - birthYear;
        int dayAge = age * 365;
        int firstNameCounter = firstName.Length;

        int firstNameRandom = rnd.Next(0, firstNameCounter);

        print("Your name is: " + firstName + " " + lastName);
        print("Your initials are: " + firstName[0] + lastName[0]);
        print("The length of your full name is: " + fullName.Length);
        print("Here is a random letter from your first name: " + firstName[firstNameRandom]);
        print("You were born in " + birthYear + " which means you are " + age.ToString());
        print("You have been alive for: " + dayAge.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
