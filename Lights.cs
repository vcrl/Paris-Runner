using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lights : MonoBehaviour
{
    public Text lightsText;

    // Update is called once per frame
    void Update()
    {
        lightsText.text = GameObject.Find("Player").GetComponent<PickupCollectibles>().playerScore.ToString("0");
    }
}