using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public bool hasWon = false;

    private void Start()
    {
        GameObject.Find("Player").GetComponent<Animator>().SetBool("hasWon", hasWon);
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            GameObject.Find("GameOver/Win").GetComponent<DisplayGameOver>().DisplayGameOverText("GAME OVER");
            Invoke("RestartGame", 4f);
        }
        
    }

    public void GameOverWin()
    {
        if (gameHasEnded == false)
        {
            hasWon = true;
            gameHasEnded = true;
            Debug.Log("Game over");
            GameObject.Find("GameOver/Win").GetComponent<DisplayGameOver>().DisplayGameOverText("YOU WIN");
            Invoke("StartMenu", 4f);
            GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
