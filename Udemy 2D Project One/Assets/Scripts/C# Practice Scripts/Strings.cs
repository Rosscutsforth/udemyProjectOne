using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello".Substring(2, 2));
        print("Hello".Length);
        print("Hello"[4]);
        print("Hello" + " " + "World");
        print("I was born into this world with no mind".Substring(10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
