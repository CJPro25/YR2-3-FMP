using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GrandmasHouse()
    {
        SceneManager.LoadScene("Scene 2");
    }
}

