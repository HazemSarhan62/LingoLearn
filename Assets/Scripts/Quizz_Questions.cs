using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizz_Questions : MonoBehaviour
{
    public GameObject Question1;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;
    public static string newQuestion;
    public static string new1;
    public static string new2;
    public static string new3;
    public static string new4;
    public static bool PleaseUpdate = false;

    void Update()
    {
      if (PleaseUpdate == false)
        {
            PleaseUpdate = true;
            StartCoroutine(PushTextOnScreen());
        }  
    }
IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        Question1.GetComponent<Text>().text = newQuestion;
        answer1.GetComponent<Text>().text = new1;
        answer2.GetComponent<Text>().text = new2;
        answer3.GetComponent<Text>().text = new3;
        answer4.GetComponent<Text>().text = new4;

    }
}
