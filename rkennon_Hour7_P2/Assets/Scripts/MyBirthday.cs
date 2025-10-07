using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyBirthday : MonoBehaviour
{
    void Start()
    {
         for(int June = 1; June <= 30; June++)
         {
             if(June == 11)
             {
                 Debug.Log("Its my birthday!");
             }
             else
             {
                 Debug.Log(June);
             }
         }
    }
}