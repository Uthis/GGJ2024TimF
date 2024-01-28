using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    private Text title;
    private int level;

    private void Awake()
    {
        title = GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        level = PlayerPrefs.GetInt("LevelNumber");

        switch (level)
        {
            case 1:
                title.text = "1";
            break;
            case 2:
                title.text = "2";
            break;
            case 3:
                title.text = "3";
            break;
            case 4:
                title.text = "4";
            break;
            case 5:
                title.text = "5";
            break;
        }
    }
}
