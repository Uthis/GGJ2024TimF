using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_Back : MonoBehaviour
{
    public void Backmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
