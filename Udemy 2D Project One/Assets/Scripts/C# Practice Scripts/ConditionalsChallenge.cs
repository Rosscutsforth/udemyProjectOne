using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsChallenge : MonoBehaviour
{

    public int numberOne;
    public int numberTwo;

    // Start is called before the first frame update
    void Start()
    {
        if (numberOne > numberTwo)
        {
            print("Number one is bigger than number two");
        }
        else if (numberTwo > numberOne)
        {
            print("Number two is bigger than number one");
        }
        else
        {
            print("The numbers are the same");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
