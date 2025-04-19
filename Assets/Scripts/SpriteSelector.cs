using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteSelector : MonoBehaviour
{
    // on button press, select sprite 1 or sprite 2

    public void SelectSprite01()
    {
        PlayerPrefs.SetInt("spriteChoice", 0);
        SceneManager.LoadScene("CustomScene");
    }

    public void SelectSprite02()
    {
        PlayerPrefs.SetInt("spriteChoice", 1);
        SceneManager.LoadScene("CustomScene");
    }
}
