using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehavior : MonoBehaviour
{

    [SerializeField] private GameObject levelCompletePopup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // pause game and show popup
        Time.timeScale = 0f;
        levelCompletePopup.SetActive(true);
    }

    // reuturn to start
    public void ReturnToWelcomeScreen()
    {
        Time.timeScale = 1f;  // resume time
        SceneManager.LoadScene("WelcomeScreen");
    }
}
