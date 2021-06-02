using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGameOver : MonoBehaviour
{
    public Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.enabled = false;
    }

    public void DisplayGameOverText(string GameOver)
    {
        gameOverText.enabled = true;
        gameOverText.text = GameOver;
    }
}
