using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DiagueManager : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] Sentences;
    private int index = 0;
    public float DialogueSpeed;
    public Animator DialogueAnimator;
    private bool IsDialogueOpen = true;

    /*void Start()
    {
        StartCoroutine(WriteSentence());
    }*/

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (IsDialogueOpen)
            {
                DialogueAnimator.SetTrigger("Entry");
                IsDialogueOpen = false;
            }
            else
            {
                NextSentece();
            }
        }
    }

    void NextSentece()
    {
        if(index <= Sentences.Length - 1)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentence());
        }
        else
        {
            DialogueText.text = "";
            DialogueAnimator.SetTrigger("Exit");
            index = 0;
            IsDialogueOpen = true;
        }
    }

    IEnumerator WriteSentence()
    {
        foreach(char Character in Sentences[index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        index++;
    }
}
