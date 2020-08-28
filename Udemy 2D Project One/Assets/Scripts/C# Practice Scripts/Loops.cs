using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    int number = 1;

    // Start is called before the first frame update
    void Start()
    {
        while (number <= 10)
        {
            print(number);
            number += 1;
        }

        for (int i = 1; i <= 10; i += 1)
        {
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
