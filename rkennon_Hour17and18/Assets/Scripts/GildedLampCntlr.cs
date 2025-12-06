using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GildedLampCntlr : MonoBehaviour
{

    Animator LampAnim;
    /*
    Animator RotateAnim;
    Animator CoreAnim;
    */
    void Start()
    {
        /*
        GameObject parent = GameObject.Find("GildedLamp");
        GameObject child1 = GameObject.Find("LightCore");
        GameObject child2 = GameObject.Find("GlassCenter");
        */
        LampAnim = GetComponent<Animator>();
        /*
        RotateAnim = parent.GetComponentInChildren<Animator>(child2);
        CoreAnim = parent.GetComponentInChildren<Animator>(child1);
        */
    }
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.D) )
        {
            LampAnim.SetTrigger("Floater");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            LampAnim.SetTrigger("Rotator");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            LampAnim.SetTrigger("Scaler");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            LampAnim.SetTrigger("Colorer");
        }
    }
}