using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class XPScript : MonoBehaviour
{
    private int xp;
    public Text LevelCounterText;
    public Slider XPBar;
    public GameObject XPObject;
    

    public void IncreaseXP()
    {
        xp++;
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp;
        DontDestroyOnLoad(XPObject); 
    }

     

}
