using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager :  MonoBehaviour
{
    private static int xp;
    public  Slider XPBar;
    public  Text LevelCounterText;

    public int getXP()
    {
        return xp;
    }

    public void setXP()
    {
        xp++;
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp;
        Debug.Log("Health Increased to: " + xp);
    }
}
