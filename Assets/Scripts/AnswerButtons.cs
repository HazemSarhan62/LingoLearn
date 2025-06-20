using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject Answer1backBlue; //Blue means Wait
    public GameObject Answer1backGreen; //Green means Correct
    public GameObject Answer1backRed; //Red means Wrong
    public GameObject Answer2backBlue; //Blue means Wait
    public GameObject Answer2backGreen; //Green means Correct
    public GameObject Answer2backRed; //Red means Wrong
    public GameObject Answer3backBlue; //Blue means Wait
    public GameObject Answer3backGreen; //Green means Correct
    public GameObject Answer3backRed; //Red means Wrong
    public GameObject Answer4backBlue; //Blue means Wait
    public GameObject Answer4backGreen; //Green means Correct
    public GameObject Answer4backRed; //Red means Wrong

    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;
    public GameObject currentScore;
    public int ScoreValue;
    public int BestScore;
    public GameObject BestDisplay;

    void Start()
    {
        BestScore = PlayerPrefs.GetInt("BestScoreQuizz");
        BestDisplay.GetComponent<Text>().text = "BEST: " + BestScore;
    }

    void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + ScoreValue;
    }
    
    public void Answer1()
    {
        if (GenerateQuestion.ActualAnswer == "1")
        {
            Answer1backGreen.SetActive(true);
            Answer1backBlue.SetActive(false);
            ScoreValue += 1;
        }
        else
        {
            Answer1backRed.SetActive(true);
            Answer1backBlue.SetActive(false);
            ScoreValue -= 1 ;

        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void Answer2()
    {
        if (GenerateQuestion.ActualAnswer == "2")
        {
            Answer2backGreen.SetActive(true);
            Answer2backBlue.SetActive(false);
            ScoreValue += 1;
        }
        else
        {
            Answer2backRed.SetActive(true);
            Answer2backBlue.SetActive(false);
            ScoreValue -= 1;

        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void Answer3()
    {
        if (GenerateQuestion.ActualAnswer == "3")
        {
            Answer3backGreen.SetActive(true);
            Answer3backBlue.SetActive(false);
            ScoreValue += 1;
        }
        else
        {
            Answer3backRed.SetActive(true);
            Answer3backBlue.SetActive(false);
            ScoreValue -= 1;

        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void Answer4()
    {
        if (GenerateQuestion.ActualAnswer == "4")
        {
            Answer4backGreen.SetActive(true);
            Answer4backBlue.SetActive(false);
            ScoreValue += 1;
        }
        else
        {
            Answer4backRed.SetActive(true);
            Answer4backBlue.SetActive(false);
            ScoreValue -= 1;

        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    IEnumerator NextQuestion()
    {
        if(BestScore < ScoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuizz", ScoreValue);
            BestScore = ScoreValue;
            BestDisplay.GetComponent<Text>().text = "BEST: " + ScoreValue;
        }

        yield return new WaitForSeconds(2);

        Answer1backGreen.SetActive(false);
        Answer2backGreen.SetActive(false);
        Answer3backGreen.SetActive(false);
        Answer4backGreen.SetActive(false);

        Answer1backRed.SetActive(false);
        Answer2backRed.SetActive(false);
        Answer3backRed.SetActive(false);
        Answer4backRed.SetActive(false);


        Answer1backBlue.SetActive(true);
        Answer2backBlue.SetActive(true);
        Answer3backBlue.SetActive(true);
        Answer4backBlue.SetActive(true);

        answer1.GetComponent<Button>().enabled = true;
        answer2.GetComponent<Button>().enabled = true;
        answer3.GetComponent<Button>().enabled = true;
        answer4.GetComponent<Button>().enabled = true;
        GenerateQuestion.DisplayQuestion = false;
    }

}
