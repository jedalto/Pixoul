using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteColorChanger : MonoBehaviour
{
    public void SelectCyan()
    {
        PlayerPrefs.SetInt("spriteColor", 0);
        //SceneManager.LoadScene("CustomScene");
    }

    public void SelectYellow()
    {
        PlayerPrefs.SetInt("spriteColor", 1);
        //SceneManager.LoadScene("CustomScene");
    }
}
