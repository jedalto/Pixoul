using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<Questions> QnA;
    public GameObject[] options;
    public int currentQuestionIndex;

    public TextMeshProUGUI QuestionTxt;

    public List<int> playerAnswers = new List<int>();

    private void Start()
    {
        // TODO
        currentQuestionIndex = 0;
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestionIndex].Answers[i];
        }
    }

    void generateQuestion()
    {
        QuestionTxt.text = QnA[currentQuestionIndex].Question;
        SetAnswers();
    }

    public void Answer(int selectedAnswerIndex)
    {
        playerAnswers.Add(selectedAnswerIndex);  // store the selected index
        currentQuestionIndex++;

        // record answer -> maybe use some kind of table to determine which trait of custom environment this adds to
        if (currentQuestionIndex < QnA.Count)
        {
            generateQuestion();
        } else
        {
            ProcessResults();
            SceneManager.LoadScene("CustomScene");
        }
    }

    void ProcessResults()
    {
        int totalAnswers = playerAnswers.Count;

        PlayerPrefs.SetInt("spriteChoice", playerAnswers[0]);
        PlayerPrefs.SetInt("spriteColor", playerAnswers[2]);
        PlayerPrefs.SetInt("groundTextureChoice", playerAnswers[3]);
        PlayerPrefs.SetInt("backgroundTextureChoice", playerAnswers[4]);

        for (int i = 0; i < playerAnswers.Count; i++)
        {
            // TODO: translate answers to traits
            // store in PlayerPrefs
        }
    }
}
