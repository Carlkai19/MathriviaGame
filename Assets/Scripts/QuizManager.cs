using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{

    public List<QnA> QnAList;
    public GameObject[] options;
    public int CurrentQuestions;
    public Text QuestionTxt;

    public HealthManager PlayerHP; //this is how I called the script from the player halthbar!

    public GameObject QuizPanel;
    public GameObject ItemToDestroyOnceCompletion;

    // Start is called before the first frame update
    void Start() //as for right now is on the Start method. However, I should change this soon to an update whenever the player
                 //presses E with a door or interactable. I will have to do some testing.      
    {
        generateQuestions();
        QuizPanel.SetActive(false);
    }
    private void Update()
    {
        
    }
    public void QuizPanelOn()
    {
        QuizPanel.SetActive(true);
    }
    public void correct()
    {
        //when you are right 
<<<<<<< HEAD

        PlayerHP.Heal(15); //this is from the healthManager script. 
=======
        PlayerHP.Heal(5); //this is from the healthManager script. 
>>>>>>> cf417f42fdcae609575635e26fc9eb14d73741d3
        QnAList.RemoveAt(CurrentQuestions);
        generateQuestions();

    }
    public void wrong()
    {
        //when you answer wrong. 
<<<<<<< HEAD

        PlayerHP.TakeDamage(10);

=======
        PlayerHP.TakeDamage(15);
>>>>>>> cf417f42fdcae609575635e26fc9eb14d73741d3
        QnAList.RemoveAt(CurrentQuestions);
        generateQuestions();
    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScripts>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnAList[CurrentQuestions].Answers[i];

            if (QnAList[CurrentQuestions].CorrectAnswers == i+1)
            {
                options[i].GetComponent<AnswerScripts>().isCorrect = true;
            }
        }
    }

   
    void generateQuestions()

    {  
        if(QnAList.Count > 0)
        {
        //here we randomly pick a question from the QnAList; 
        CurrentQuestions = Random.Range(0, QnAList.Count);
        //display the question from the list
        QuestionTxt.text = QnAList[CurrentQuestions].Question;

        SetAnswers();
        }
        else
        {
            Debug.Log("Out Of Questions!");
            QuizPanel.SetActive(false );

            Destroy(ItemToDestroyOnceCompletion);
            //it worked!
            
        }
        
        

        
    }

    
}
