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
    [SerializeField] Animator animSalah;
    [SerializeField] AudioClip clipBenar,clipSalah,clipGameOver;
    [SerializeField] AudioSource source;

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
            txtAnswer.gameObject.SetActive(true);
            source.PlayOneShot(clipBenar);
            if (level >= 5) btnNext.GetComponentInChildren<Text>().text = "Bonus";
        }
        else
        {
            health--;
            RefreshHeart();
            source.PlayOneShot(clipSalah);
            animSalah.Play("FadeIn");
            txtInputAnswer.text = "";
            if (health <= 0)
            {
                source.PlayOneShot(clipGameOver);
                panelGameOver.SetActive(true);
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
            GameManager.instance.PlayBonus();
    }

    public void Retry()
    {
        GameManager.instance.PlayGame();
    }
}
