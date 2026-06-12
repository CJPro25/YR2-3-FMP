using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Scene 1");
    }

    public void GrandmasHouse()
    {
        SceneManager.LoadScene("Scene 2");
    }
}

