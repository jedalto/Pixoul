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

    public void Answer()
    {
        currentQuestionIndex++;
        // record answer -> maybe use some kind of table to determine which trait of custom environment this adds to
        if (currentQuestionIndex < QnA.Count)
        {
            generateQuestion();
        } else
        {
            SceneManager.LoadScene("CustomScene");
        }
    }
}
