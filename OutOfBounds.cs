using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
  public Canvas GameOverUI; //Reference to Game Over Canvas
  public float yDistanceToShowGameOver = -30.0f; // Adjust this value if needed

    private bool gameIsOver = false;

    private void Update()
    {
        if (!gameIsOver && transform.position.y < yDistanceToShowGameOver)
        {
            //Character has gone out of the screen. Show the Game Over Canvas.
            GameOverUI.gameObject.SetActive(true);
        }
    }
}
