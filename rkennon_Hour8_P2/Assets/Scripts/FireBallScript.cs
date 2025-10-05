using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }
    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;
        return playerHealth - damage;
    }
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
    void Start()
    {
        int x = TakeDamageFromFireball();
        Debug.Log("Player health: " + x);
        int y = TakeDamageFromFireball(25);
        Debug.Log("Player health: " + y);
        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("Player health: " + z);
    }
}
