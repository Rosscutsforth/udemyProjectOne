using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraChallenges : MonoBehaviour
{

    int[] addingNumbers = new int[] { 3, 21, 3, 8, -22 };
    string[] sentence = new string[] { "Hello", "my", "name", "is", "Ross" };
    int[] maxNumber = new int[] { 88, 6, 32, 132, 800 };

    string[] uniformSentence = new string[] { "hi", "hi", "hi", "hi" };
    string[] chaoticSentence = new string[] { "yo", "cheese", "nebula", "hurrow" };
    string[] semiChaoticSentence = new string[] { "yo", "yo", "yo", "yo", "hurrow" };



    int SumArray(int[]arr)
    {
        int arrayLength = arr.Length;
        int arrayCounter = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            arrayCounter += arr[i];
        }
        return arrayCounter;
    }

    int Max(int[]maxNum)
    {
        int maxNumLength = maxNum.Length - 1;
        int greatestNumber = 0;

        for (int i = 0; i < maxNumLength; i++)
        {
            if (maxNum[i] > maxNum[maxNumLength])
            {
                greatestNumber = maxNum[i];
            }
            else if(maxNum[maxNumLength] >= maxNum[i])
            {
                greatestNumber = maxNum[maxNumLength];
            }
        }
        return greatestNumber;
    }

    bool isuniform(string[]uniform)
    {
        int uniformLength = uniform.Length - 1;
        int counter = 0;

        while (counter < uniformLength)
        {
            if (uniform[counter] == uniform[uniformLength])
            {
                counter++;
                if (counter == uniformLength)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        return false;

        //for (int i = 0; i < uniformlength;)
        //{
        //    if (uniform[i] == uniform[uniformlength])
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }

    void Start()
    {
        print(SumArray(addingNumbers));

        int sentenceLength = sentence.Length - 1;

        for (int i = sentenceLength; i >= 0; i--)
        {
            print(sentence[i]);
        }

        print(Max(maxNumber));

        print(isuniform(uniformSentence));
        print(isuniform(chaoticSentence));
        print(isuniform(semiChaoticSentence));
    }

}
