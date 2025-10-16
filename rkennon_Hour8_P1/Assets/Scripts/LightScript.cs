using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent;
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && lightComponent.enabled == false)
            lightComponent.enabled = true;
        else if (Input.GetKeyDown(KeyCode.L) && lightComponent.enabled == true)
            lightComponent.enabled = false;
    }
}
