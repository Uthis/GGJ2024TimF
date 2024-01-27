using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScriptManager : MonoBehaviour
{
    public Image tebakan;
    public Sprite level1Sprite;
    public Sprite level2Sprite;
    public Sprite level3Sprite;
    public Sprite level4Sprite;
    public Sprite level5Sprite;
    private int level;

    void Update()
    {
        level = PlayerPrefs.GetInt("LevelNumber");

        switch (level)
        {
            case 1:
                tebakan.sprite = level1Sprite;
            break;
            case 2:
                tebakan.sprite = level2Sprite;
            break;
            case 3:
                tebakan.sprite = level3Sprite;
            break;
            case 4:
                tebakan.sprite = level4Sprite;
            break;
            case 5:
                tebakan.sprite = level5Sprite;
            break;
        }

        
    }
}
