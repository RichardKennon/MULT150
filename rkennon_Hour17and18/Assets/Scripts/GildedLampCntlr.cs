using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GildedLampCntlr : MonoBehaviour
{
    Animator FloatAnimator;

    void Start()
    {
        FloatAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool floater = Input.GetKeyDown(KeyCode.D);

        FloatAnimator.SetBool("Floater", floater);
    }
}
