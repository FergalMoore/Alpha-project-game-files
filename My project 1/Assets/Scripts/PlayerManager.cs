using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    // Initializes game state variables at the start.
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1.0f;
    }

    // Pauses the game and activates the "gameOverPanel" when the "gameOver" condition is true.
   
    void Update()
    {
        if (gameOver)
        {

            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
