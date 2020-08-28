using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{


    int[] randomNumbers = new int[3];


    void Start()
    {
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            randomNumbers[i] = UnityEngine.Random.Range(0, 100);
            print(randomNumbers[i]);
        }
    }


}
