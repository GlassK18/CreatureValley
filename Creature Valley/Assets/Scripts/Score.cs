using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float scoreamount;
    public float pointincrease;
    public Text scoretext;

    void Start()
    {
        scoreamount = 0f;
        pointincrease = 30f;

    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = (int)scoreamount+ "";
        scoreamount += pointincrease * Time.deltaTime;
           
    }
}
