using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text Score;
    public Text Finaltext;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Finaltext.text = "Final Score = " + Score.text;
        Score.enabled = false;
    }
}
