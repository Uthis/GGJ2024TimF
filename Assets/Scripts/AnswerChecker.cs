using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerChecker : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject cutOut;
    public Button hint;
    public GameObject inputAnswer;
    public GameObject checkAnswer;
    public GameObject back;
    public GameObject next;
    private int heartCount = 5;
    public InputField answer;

    void Start()
    {
        back.SetActive(false);
        next.SetActive(false);
    }
    public void Checker()
    {
        if (answer.text == "#")
        {
            hint.interactable = false;
            cutOut.GetComponent<Animator>().Play("CutOut");
            back.SetActive(true);
            next.SetActive(true);
            checkAnswer.SetActive(false);
            inputAnswer.SetActive(false);
            
        }
        else if (answer.text != "#" && heartCount == 5)
        {
            Destroy(heart5);
            heartCount--;
        }
        else if (answer.text != "#" && heartCount == 4)
        {
            Destroy(heart4);
            heartCount--;
        }
        else if (answer.text != "#" && heartCount == 3)
        {
            Destroy(heart3);
            heartCount--;
        }
        else if (answer.text != "#" && heartCount == 2)
        {
            Destroy(heart2);
            heartCount--;
        }
        else if (answer.text != "#" && heartCount == 1)
        {
            Destroy(heart1);
            heartCount--;
        }
    }
}
