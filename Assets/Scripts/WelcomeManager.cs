using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("QuizScene");
    }

    public void QuitGame()
    {
        #if UNITY_WEBGL && !UNITY_EDITOR
            // fullscreen exit
            Screen.fullScreen = false;
        #elif UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;  // stop play mode
        #else
            Application.Quit();  // for exe builts
        #endif

    }
}
