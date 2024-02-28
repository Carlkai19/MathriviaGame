using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScripts : MonoBehaviour
{

    public bool isCorrect = false;
    public QuizManager quizManager;
    
    public float damage;
    public float Heal;

    public void Update()
    {
       
    }
    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("CorrectAnswer!");
            quizManager.correct();
            
            
        }
        else
        
        {
            Debug.Log("Wrong Answer!");
            quizManager.wrong();
            
        }
    }
}
