using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHomeScene : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("CreatureScreen");
    }
}