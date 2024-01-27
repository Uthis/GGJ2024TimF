using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelSelectingScript : MonoBehaviour
{
    int level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelSelecting1()
    {
        level = 1;
        PlayerPrefs.SetInt("LevelNumber", level);
        SceneManager.LoadScene("Game");
    }

    public void LevelSelecting2()
    {
        level = 2;
        PlayerPrefs.SetInt("LevelNumber", level);
        SceneManager.LoadScene("Game");
    }

    public void LevelSelecting3()
    {
        level = 3;
        PlayerPrefs.SetInt("LevelNumber", level);
        SceneManager.LoadScene("Game");
    }

    public void LevelSelecting4()
    {
        level = 4;
        PlayerPrefs.SetInt("LevelNumber", level);
        SceneManager.LoadScene("Game");
    }

    public void LevelSelecting5()
    {
        level = 5;
        PlayerPrefs.SetInt("LevelNumber", level);
        SceneManager.LoadScene("Game");
    }
}
