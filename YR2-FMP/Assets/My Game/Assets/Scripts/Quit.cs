using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void quitTheGame()
    {

#if UNITY_EDITOR
        // Stop playing the scene in the editor
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
        // WebGL can't quit, but we can log or redirect
        Debug.Log("Quit requested - can't exit in WebGL. Maybe redirect or show UI?");
#else
        Application.Quit();
#endif
    }
}