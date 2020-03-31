using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject gameoverui;
    public static bool gameispaused;
   

    public void NewGame()
    {
        SceneManager.LoadScene("FeedMinigameScene");
        Time.timeScale = 1f;
        gameispaused = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision .collider .tag == "Obstacle")
        {
            movement.enabled = false;
            gameoverui.SetActive(true);
            Time.timeScale = 0f;
            gameispaused = true;
        }
    }
}
