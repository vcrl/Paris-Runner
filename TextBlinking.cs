using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBlinking : MonoBehaviour
{
    public Text startText;
    public double speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //startText.GetComponent<Color>().a = (Mathf.Sin(Time.time * 2) + 1.0f) / 2.0f;
    }
}
