using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager :  MonoBehaviour
{
    public static int xp;
    public int midxp;
    public int maxxp;
    public Slider XPBar;
    public Text LevelCounterText;
    public GameObject ManticoreCreature0;
    public GameObject ManticoreCreature1;
    public GameObject ManticoreCreature2;

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

            if (xp >= midxp)
            {
                ManticoreCreature0.SetActive(false);
                ManticoreCreature1.SetActive(true);
            }

            if (xp == maxxp)
            {
                ManticoreCreature0.SetActive(false);
                ManticoreCreature1.SetActive(false);
                ManticoreCreature2.SetActive(true);
            }

        }
    }

    public void UpdateScreen()
    {
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp;

        if (xp >= midxp)
        {
            ManticoreCreature0.SetActive(false);
            ManticoreCreature1.SetActive(true);
        }

        if (xp == maxxp)
        {
            ManticoreCreature0.SetActive(false);
            ManticoreCreature1.SetActive(false);
            ManticoreCreature2.SetActive(true);
        }

    }

    public void LoadCreatureScene()
    {
        SceneManager.LoadScene("CreatureScreen");
        setXP();
    }

    public void LoadPlayMinigameScene()
    {
        SceneManager.LoadScene("PlayMinigameScene");
    }

    public void LoadMinigame2Scene()
    {
        SceneManager.LoadScene("Minigame2Scene");
    }

    public void LoadMinigame3Scene()
    {
        SceneManager.LoadScene("Minigame3Scene");
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScreenScrene");
    }

    public void Start()
    {
        LevelCounterText.text = "Level: " + xp;
        XPBar.value = xp;

        if (xp >= midxp)
        {
            ManticoreCreature0.SetActive(false);
            ManticoreCreature1.SetActive(true);
        }

        if (xp == maxxp)
        {
            ManticoreCreature0.SetActive(false);
            ManticoreCreature1.SetActive(false);
            ManticoreCreature2.SetActive(true);
        }
    }

    public void Update()
    {
        UpdateScreen();
    }

    public void CloseGame()
    {
        Application.Quit();
    }

   
}

