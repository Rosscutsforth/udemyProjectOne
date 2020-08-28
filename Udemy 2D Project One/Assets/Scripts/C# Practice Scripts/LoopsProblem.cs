using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsProblem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -5; i <= 5; i++)
        {
            print(i);
        }

        for (int e = 10; e <= 50; e += 2)
        {
            print(e);
        }

        for (int d = 1; d <= 100; d++)
        {
            if (d % 3 == 0 || d % 5 == 0)
            {
                print(d);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
