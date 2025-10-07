using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int EvenNum = 22; EvenNum <= 100; EvenNum = EvenNum + 2)
        {
            Debug.Log(EvenNum);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
