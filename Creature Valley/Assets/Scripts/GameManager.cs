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

    public void UpdateScreen()
    {
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp;
        
    }

    public void LoadCreatureScene()
    {
        SceneManager.LoadScene("CreatureScreen");
        setXP();
        
    }

    public void LoadMinigame1Scene()
    {
        SceneManager.LoadScene("Minigame1Scene");
    }

    public void LoadMinigame2Scene()
    {
        SceneManager.LoadScene("Minigame2Scene");
    }

    public void LoadMinigame3Scene()
    {
        SceneManager.LoadScene("Minigame3Scene");
    }

    public void Start()
    {
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp; 
    }
}
