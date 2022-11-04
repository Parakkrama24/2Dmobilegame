using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int i= 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       for ( i=0; i < 30; i++)
        {
            while (i < 10)
            {
                print(i);
            }
        }
    }
}
