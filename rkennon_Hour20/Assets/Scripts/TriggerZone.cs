using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // I took a look at the "SUS" scripts, and I honestly would have made the TriggerZone look like that since the 
    // void Start(){} and void Update(){} were unnecessary- but I'd rather not have my scripts look like duplicates.

    // I always type these out regardless. Unless they're kept in the original 24 hours download, I can't imagine where to copy and paste them anyway.

    void OnTriggerEnter (Collider other)
    {
        Destroy(other.gameObject);
    }
}
