using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Image toggleImage;
    [SerializeField] private Sprite toggleImageOn;
    [SerializeField] private Sprite toggleImageOff;

    public void Quit()
    {
        GameManager.instance.Quit();
    }

    public void ToggleBGM()
    {
        GameManager.instance.ToggleSound();
        toggleImage.sprite = GameManager.instance.isSound() ? toggleImageOn : toggleImageOff;
    }

    
}
