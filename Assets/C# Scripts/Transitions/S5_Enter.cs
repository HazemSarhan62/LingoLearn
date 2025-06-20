using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S5_Enter : MonoBehaviour
{ 
    public void LoadSceneByIndex1(int sceneIndex)
{
    if (sceneIndex < SceneManager.sceneCountInBuildSettings)
    {
        SceneManager.LoadScene(2);
    }
    else
    {
        Debug.LogWarning("Invalid scene index: " + sceneIndex);
    }
}
    public void LoadSceneByIndex2(int sceneIndex)
    {
        if (sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            Debug.LogWarning("Invalid scene index: " + sceneIndex);
        }
    }

    // Call this to quit the game
    public void QuitGame()
{
    Debug.Log("Quitting game...");

#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false; // Works in Unity editor
#else
        Application.Quit(); // Works in build
#endif
}
}
