using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Text lifeText;

    // Update is called once per frame
    void Update()
    {
        lifeText.text = GameObject.Find("Player").GetComponent<PlayerCollision>().playerLives.ToString("0");
    }
}