using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadMinigame1Scene()
    {
        SceneManager.LoadScene("Minigame1Scene");
        UnityEditor.SceneView.RepaintAll();
    }

    public void Start()
    {
        UnityEditor.SceneView.RepaintAll();
    }
}