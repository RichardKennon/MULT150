using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    int BuiltLamps = 0;

    void Start()
    {
        StreetLiner();
        Debug.Log("There are " + BuiltLamps + " built lamps!");
    }

    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab.
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to.
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }

    }

    void StreetLiner()
    {
        for (int count = 1; count <= 10; count++)
        {
            BuiltLamps++;
            Instantiate(prefab, transform.position, transform.rotation);
            transform.Translate(10f, 0f, 0f);
        }
    }
}
