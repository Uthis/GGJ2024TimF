using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SilhouettePlay : MonoBehaviour
{
    [SerializeField] GameObject silhouette,image,option1,option2,option3,option4,confirm,txtAsk,txtAnswer,btnHome;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip Answerclip,pokemonAfter;

    public void ShowAnswer()
    {
        silhouette.SetActive(false);
        image.SetActive(true);
        txtAnswer.SetActive(true);
        audioSource.PlayOneShot(Answerclip);
        btnHome.SetActive(true);
    }

    public void SpinSilhouette()
    {
        option1.SetActive(false);
        option2.SetActive(false);
        option3.SetActive(false);
        option4.SetActive(false);
        txtAsk.SetActive(false);
        confirm.SetActive(false);
        GetComponent<Animator>().Play("spin");
        audioSource.PlayOneShot(pokemonAfter);
    }

    public void ToMainMenu()
    {
        GameManager.instance.BackToMenu();
    }

    public void Confirm()
    {
        confirm.SetActive(true);
    }
}
