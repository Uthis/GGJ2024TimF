using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class LevelSelectingScript : MonoBehaviour
{
    /*private int level;
    private int levelProgress = 1;
    [SerializeField] private Text[] levelText;
    [SerializeField] private GameObject[] locks;
    [SerializeField] private GameObject[] text;
    private Sprite unlock;
    private Sprite locked;

    private void Awake()
    {
        levelProgress = PlayerPrefs.GetInt("LevelProgress");
        for (int i = 0; i<5; i++)
        {
            Debug.Log(levelText[i]);
            locks[i].SetActive(true);
            text[i].SetActive(false);
        }        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LockSystem();
    }

    public void LockSystem()
    {
        if (levelProgress >= 1)
        {
            levelText[0].text = "1";
            locks[0].SetActive(false);
            text[0].SetActive(true);
        }
        if (levelProgress >= 2)
        {
            levelText[1].text = "2";
            locks[1].SetActive(false);
            text[1].SetActive(true);
        }
        if (levelProgress >= 3)
        {
            levelText[2].text = "3";
            locks[2].SetActive(false);
            text[2].SetActive(true);
        }
        if (levelProgress >= 4)
        {
            levelText[3].text = "4";
            locks[3].SetActive(false);
            text[3].SetActive(true);
        }
        if (levelProgress >= 5)
        {
            levelText[4].text = "5";
            locks[4].SetActive(false);
            text[4].SetActive(true);
        }
    }

    public void Win()
    {
        levelProgress++;
        PlayerPrefs.SetInt("LevelProgress", levelProgress);
    }

    public void LevelSelecting1()
    {
        if (levelProgress >= 1)
        {
            level = 1;
            PlayerPrefs.SetInt("LevelNumber", level);
            SceneManager.LoadScene("Game");
        }
    }

    public void LevelSelecting2()
    {
        if (levelProgress >= 2)
        {
            level = 2;
            PlayerPrefs.SetInt("LevelNumber", level);
            SceneManager.LoadScene("Game");
        }
    }

    public void LevelSelecting3()
    {
        if (levelProgress >= 3)
        {
            level = 3;
            PlayerPrefs.SetInt("LevelNumber", level);
            SceneManager.LoadScene("Game");
        }
    }

    public void LevelSelecting4()
    {
        if (levelProgress >= 4)
        {
            level = 4;
            PlayerPrefs.SetInt("LevelNumber", level);
            SceneManager.LoadScene("Game");
        }
    }

    public void LevelSelecting5()
    {
        if (levelProgress >= 1)
        {
            level = 5;
            PlayerPrefs.SetInt("LevelNumber", level);
            SceneManager.LoadScene("Game");
        }
    }*/
}
