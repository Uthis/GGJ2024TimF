using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;

    [SerializeField] Text txtClue,txtInputAnswer,txtAnswer;
    [SerializeField] List<GameObject> levels;
    [SerializeField] GameObject btnNext, btnHome, inputAnswer, btnCheck;
    [SerializeField] GameObject panelGameOver;
    [SerializeField] Sprite heartActive,heartInactive;
    [SerializeField] List<Image> hearts;
    [SerializeField] AudioSource winSound, loseSound;
    int level,showedClues,health;
    Level currLevel;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        level = PlayerPrefs.GetInt("level");
        GameObject g = levels[level - 1];
        g.SetActive(true);
        currLevel = g.GetComponent<Level>();
        txtClue.text = currLevel.clues[0];
        showedClues = 1;
        health = 5;
        RefreshHeart();
    }

    public void Hint()
    {
        if(showedClues < currLevel.clues.Count)
        txtClue.text += ", " + currLevel.clues[showedClues];
        showedClues++;
    }

    public void Check()
    {
        string answer = txtInputAnswer.text;
        if(answer.ToLower().Trim() == currLevel.answer.ToLower().Trim())
        {
            currLevel.transform.GetChild(0).GetComponent<Animator>().Play("CutOut");
            PlayerPrefs.SetInt("LevelProgress", level);
            btnNext.SetActive(true);
            btnHome.SetActive(true);
            btnCheck.SetActive(false);
            inputAnswer.SetActive(false);
            txtClue.gameObject.SetActive(false);
            txtAnswer.text = "Aku adalah " + currLevel.answer;
            winSound.Play();
        }
        else
        {
            health--;
            RefreshHeart();
            if (health <= 0)
            {
                panelGameOver.SetActive(true);
                loseSound.Play();
            }
        }
    }

    public void RefreshHeart()
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            hearts[i].sprite = i < health ? heartActive : heartInactive;
        }
    }

    public void BackToMenu()
    {
        GameManager.instance.BackToMenu();
    }

    public void Next()
    {
        if(level < 5)
        {
            PlayerPrefs.SetInt("level", level + 1);
            GameManager.instance.PlayGame();
        }else
            GameManager.instance.DoBackToMenu();
    }

    public void Retry()
    {
        GameManager.instance.PlayGame();
    }
}
