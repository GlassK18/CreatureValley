using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager :  MonoBehaviour
{
    private static int xp;
    public int imgNumberCount;
    public Slider XPBar;
    public Text LevelCounterText;
    public Sprite Stage1Manticore;
    public Sprite Stage2Manticore;
    public Sprite Stage3Manticore;

    public int getXP()
    {
        return xp;
    }

    public void setXP()
    {
        if (xp != 20)
        {
            xp++;
            LevelCounterText.text = "Level: " + xp;
            XPBar.value = xp;
        }
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
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadMinigame2Scene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadMinigame3Scene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Start()
    {
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp; 
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void changeImages() // make sure to attach this to event trigger
    {
        switch (imgNumberCount)
        {

            case 0:
                GetComponent<Image>().sprite = Stage1Manticore;
                imgNumberCount++; //increase count so it gets higher and switches to different sprite
                break;
            case 1:
                GetComponent<Image>().sprite = Stage2Manticore;
                imgNumberCount++;
                break;
            case 2:
                GetComponent<Image>().sprite = Stage3Manticore;
                imgNumberCount++;
                imgNumberCount = 0; //Reset it to 0
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }
}

