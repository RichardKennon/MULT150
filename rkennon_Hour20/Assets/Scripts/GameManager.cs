using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextureScroller ground;
    public float gameTime = 10;

    float totalTimeElapsed = 0;
    bool isGameOver = false;

    void Start()
    {
        
    }

    // Update is called once per frame and keeps track of time.
    void Update()
    {
        if (isGameOver)
            return;
        // Adds to time since last frame.
        totalTimeElapsed += Time.deltaTime;
        gameTime -= Time.deltaTime;
        // Tracks when game is over, which happens when time runs out.
        if (gameTime <= 0)
            isGameOver = true;
    }

    // Called whenever a player hits a power-up or an obstacle.
    public void AdjustTime (float amount)
    {
        // Adds or removes remaining time.
        gameTime += amount;
        // Slows game down if obstacle, or negative amount, is triggered.
        if (amount < 0)
            SlowWorldDown();
    }

    void SlowWorldDown()
    {
        // Cancel any invokes to speed the world up.  
        CancelInvoke();
        // Then slow the world down for 1 second.
        Time.timeScale = 0.5f;
        Invoke("SpeedWorldUp", 1);
    }

    void SpeedWorldUp()
    {
        Time.timeScale = 1f;
    }

    // Note this is using Unity's legacy GUI system.
    void OnGUI()
    {
        if (!isGameOver)
        {
            Rect boxRect = new Rect(Screen.width / 2 - 50, Screen.height - 100, 100, 50);
            GUI.Box(boxRect, "Time Remaining");

            Rect labelRect = new Rect(Screen.width / 2 - 10, Screen.height - 80, 20, 40);
            GUI.Label(labelRect, ((int)gameTime).ToString());
        }
        else
        {
            Rect boxRect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
            GUI.Box(boxRect, "GameOver");
            Rect labelRect = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
            GUI.Label(labelRect, "Total Time: " + (int)totalTimeElapsed);

            Time.timeScale = 0;
        }
    }
}