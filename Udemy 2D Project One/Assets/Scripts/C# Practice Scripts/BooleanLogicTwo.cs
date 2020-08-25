using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanLogicTwo : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        bool complexStatement = 5 < 10 && 5 != 5;
        print(complexStatement);

        bool complexStatement2 = 5 < 10 || 5 != 5;
        print(complexStatement2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
