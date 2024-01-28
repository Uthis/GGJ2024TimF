using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnLevel : MonoBehaviour
{
    [SerializeField] int level;
    [SerializeField] GameObject levelLock;

    // Start is called before the first frame update
    void Start()
    {
        levelLock.SetActive((!PlayerPrefs.HasKey("LevelProgress") || PlayerPrefs.GetInt("LevelProgress") < level - 1) && level != 1);
    }

    public void PlayLevel()
    {
        PlayerPrefs.SetInt("level", level);
        GameManager.instance.PlayGame();
    }
}
