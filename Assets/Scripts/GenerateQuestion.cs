using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateQuestion : MonoBehaviour
{
    public static string ActualAnswer;
    public static bool DisplayQuestion = false;
    public int QuestionNumber;

    void Update()
    {
        if (DisplayQuestion == false)
        {
            DisplayQuestion = true;
            QuestionNumber = Random.Range(1, 5);
            if (QuestionNumber == 1)
            {
                Quizz_Questions.newQuestion = "What does été mean in this statement:L'été est chaud, alors allons à la plage.\r\n"; 
                Quizz_Questions.new1 = "1. Summer";
                Quizz_Questions.new2 = "2. Spring";
                Quizz_Questions.new3 = "3. Winter";
                Quizz_Questions.new4 = "4. Autumn";
                ActualAnswer = "1";
            }

            if (QuestionNumber == 2)
            {
                Quizz_Questions.newQuestion = "What does flowers name in French";
                Quizz_Questions.new1 = "1. Flaur";
                Quizz_Questions.new2 = "2. Fleur";
                Quizz_Questions.new3 = "3. Flowr";
                Quizz_Questions.new4 = "4. Flure";
                ActualAnswer = "2";
            }

            if (QuestionNumber == 3)
            {
                Quizz_Questions.newQuestion = "What is name of these colors in French Red, Blue, Green, Black, White.";
                Quizz_Questions.new1 = "1. Noir, Bleu, Vert, Blanc, Rouge";
                Quizz_Questions.new2 = "2. Bleu ,Noir, Rouge, Vert, Blanc.";
                Quizz_Questions.new3 = "3. Rouge, Bleu, Vert, Noir, Blanc.";
                Quizz_Questions.new4 = "4. Rouge, Bleu, Blanc, Noir, Vert.";
                ActualAnswer = "3";
            }

                if (QuestionNumber == 4)
                {
                    Quizz_Questions.newQuestion = "Translate this statement to Frech I love chicken and potatoes.";
                    Quizz_Questions.new1 = "1. Je veux dire que j'aime le poisson et les pommes de terre.";
                    Quizz_Questions.new2 = "2. Je veux dire que j'aime le viande et les pommes de terre.";
                    Quizz_Questions.new3 = "3. Tu veues dire que t'aimes le poulet et pommes de tere.";
                    Quizz_Questions.new4 = "4. Je veux dire que j'aime le poulet et les pommes de terre.";
                    ActualAnswer = "4";
                }


                Quizz_Questions.PleaseUpdate = false;


            }
        }
    } 
