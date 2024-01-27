using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverScript : MonoBehaviour
{
    private int currentLevel;
    private int lastLevel;
    string currentSceneName;

    private void Awake()
    {
        currentLevel = PlayerPrefs.GetInt("LevelNumber");
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        lastLevel++;
        PlayerPrefs.SetInt("LevelProgress", currentLevel);
    }

    public void Lose()
    {

    }

    public void Next()
    {
        currentLevel++;
        PlayerPrefs.SetInt("LevelNumber", currentLevel);
        SceneManager.LoadScene(currentSceneName);
    }

    public void Retry()
    {
        SceneManager.LoadScene(currentSceneName);
    }

    public void Previous()
    {
        currentLevel--;
        PlayerPrefs.SetInt("LevelNumber", currentLevel);
        SceneManager.LoadScene(currentSceneName);
    }
}
