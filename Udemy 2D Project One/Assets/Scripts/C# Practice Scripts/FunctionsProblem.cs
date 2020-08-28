using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsProblem : MonoBehaviour
{

    public int isYourNumberEven;

    public int numberOne;
    public int numberTwo;


    bool IsEven(int testNumber)
    {
        if (testNumber % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    int WhatIsBigger(int number1, int number2)
    {
        if (number1 > number2)
        {
            return number1;
        }
        else
        {
            return number2;
        }
    }


    public string txt1 = "hello";
    public int printer1 = 5;

    void Repeat(string txt, int printer)
    {
        for (int counter = printer; counter >= 1; counter--)
        {
            print(txt);
        }
    }


    public int factorialInput;

    int Factorial(int factor)
    {
        int counter = 1;

        for (int i = 1; i <= factor; i++)
        {
            counter *= i;
        }
        return counter;
    }

    void Start()
    {
        if (IsEven(isYourNumberEven) == true)
        {
            print("Even");
        }
        else
        {
            print("Odd");
        }

        print(WhatIsBigger(numberOne, numberTwo));

        Repeat(txt1, printer1);
        print(Factorial(factorialInput));
    }

    void Update()
    {
        
    }
}
