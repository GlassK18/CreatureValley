using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Minigame1Scene");
    }
}