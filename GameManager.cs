using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
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
            gameHasEnded = true;
            Debug.Log("Game over");
            GameObject.Find("GameOver/Win").GetComponent<DisplayGameOver>().DisplayGameOverText("YOU WIN");
            Invoke("StartMenu", 4f);
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
