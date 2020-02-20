using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHomeScene : MonoBehaviour
{


    public void LoadCreatureScene()
    {
        SceneManager.LoadScene("CreatureScreen");
        
        UnityEditor.SceneView.RepaintAll();
    }

    public void Start()
    {
        UnityEditor.SceneView.RepaintAll();
    }
}