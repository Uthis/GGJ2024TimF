using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject panelConfirmation;
    [SerializeField] Text txtConfirmation;
    Action onYes;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        GetComponentInChildren<Canvas>().worldCamera = Camera.main;
    }

    public void BackToMenu()
    {
        Confirmation("Ingin kembali ke halaman awal?", DoBackToMenu);
    }

    public void DoBackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Confirmation("Ingin Keluar Game?",DoQuit);
    }

    public void DoQuit()
    {
        Application.Quit();
    }

    public void ToggleSound()
    {
        AudioSource bgm = GetComponent<AudioSource>();
        bgm.mute = !bgm.mute;
    }

    public void Confirmation(string text,Action action)
    {
        onYes = action;
        txtConfirmation.text = text;
        panelConfirmation.SetActive(true);
    }

    public void OnYes()
    {
        onYes.Invoke();
        OnNo();
    }

    public void OnNo()
    {
        onYes = null;
        panelConfirmation.SetActive(false);
    }
}
