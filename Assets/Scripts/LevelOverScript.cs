using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverScript : MonoBehaviour
{
    private int currentLevel;
    string currentSceneName = SceneManager.GetActiveScene().name;

    private void Awake()
    {
        currentLevel = PlayerPrefs.GetInt("LevelNumber");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
