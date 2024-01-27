using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int currentLevel;
    string currentSceneName;

    private AudioSource bgm;
    [SerializeField] private Image soundImg;
    [SerializeField] private Sprite soundOn;
    [SerializeField] private Sprite soundOff;
    private bool enable = true;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        bgm = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void SoundSwitch()
    {
        enable = !enable;
        bgm.mute = enable;
        if (enable)
        {
            soundImg.sprite = soundOn;
        }
        else
        {
            soundImg.sprite = soundOff;
        }
    }
}
