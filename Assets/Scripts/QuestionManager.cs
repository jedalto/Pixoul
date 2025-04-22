using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class QuestionManager : MonoBehaviour
{

    // create a class to describe our questions
    [System.Serializable]  // allows us to edit class in Unity Inspector
    public class Question
    {
        public string questionText;
        public List<string> answers;
    }

    // create a list of our Questions using class
    public List<Question> questions;
    public TMP_Text questionText;
    public GameObject answerButtonPrefab;
    public Transform answerButtonParent;  // where all the buttons should go in the UI (panel)

    // keep track of current question -> make way through list
    public int currentQuestionIndex = 0;
    // keep track of player answers for loading attributes at end
    private List<string> playerAnswers = new List<string>();
    public int totalQuestions = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (questionText == null)
        {
            Debug.LogError("questionText is NULL at runtime!");
        }
        else
        {
            Debug.Log("questionText found: " + questionText.name);
        }

        totalQuestions = questions.Count;

        DisplayQuestion();
    }

    void DisplayQuestion()
    {
         // clear all buttons in panel (clearing prev. answers)
        foreach (Transform child in answerButtonParent)
        {
            Destroy(child.gameObject);
        }

        // update new answer buttons
        if (currentQuestionIndex < questions.Count)
        {
            Question currentQuestion = questions[currentQuestionIndex];
            questionText.text = currentQuestion.questionText;

            foreach (string answer in currentQuestion.answers)
            {
                GameObject buttonObj = Instantiate(answerButtonPrefab, answerButtonParent);
                TMP_Text buttonText = buttonObj.transform.Find("AnswerText").GetComponent<TMP_Text>();
                buttonText.text = answer;

                Button btn = buttonObj.GetComponent<Button>();
                if (btn == null)
                {
                    Debug.LogError("Button component not found on prefab!");
                }

                string userAnswer = answer;
                btn.onClick.AddListener(() => OnAnswerSelected(userAnswer));
            }
        }
        else
        {
            EndQuiz();
        }
    }

    // when a user picks an answer, update log of answers and display next question
    void OnAnswerSelected(string userAnswer)
    {
        playerAnswers.Add(userAnswer);
        currentQuestionIndex++;
        DisplayQuestion();
    }

    // end quiz, load traits based on answers, load final scene
    void EndQuiz()
    {
        SceneManager.LoadScene("CustomScene");
    }








    // Update is called once per frame
    void Update()
    {
        
    }
}
