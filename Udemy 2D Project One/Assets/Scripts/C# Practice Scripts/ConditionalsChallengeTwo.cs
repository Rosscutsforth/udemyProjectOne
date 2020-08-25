using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsChallengeTwo : MonoBehaviour
{
    [Range(0, 100)]
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        if (score >= 90 && score <= 100)
        {
            print("A");
        }
        else if (score >= 80 && score <= 89)
        {
            print("B");
        }
        else if (score >= 70 && score <= 79)
        {
            print("C");
        }
        else if (score >= 65 && score <= 69)
        {
            print("D");
        }
        else if (score >= 0 && score <= 64)
        {
            print("F");
        }
        else
        {
            print("Invalid input");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
