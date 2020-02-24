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
        UnityEditor.SceneView.RepaintAll();
    }

    public void UpdateScreen()
    {
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp;
        UnityEditor.SceneView.RepaintAll();
    }

    public void LoadCreatureScene()
    {
        SceneManager.LoadScene("CreatureScreen");
        setXP();
        UnityEditor.SceneView.RepaintAll();
    }

    public void LoadMinigame1Scene()
    {
        SceneManager.LoadScene("Minigame1Scene");
        UnityEditor.SceneView.RepaintAll();
    }

    public void Start()
    {
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp;
        UnityEditor.SceneView.RepaintAll();
    }
}
