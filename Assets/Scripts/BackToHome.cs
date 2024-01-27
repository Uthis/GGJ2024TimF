using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToHome : MonoBehaviour
{
    public GameObject level;
    public GameObject menu;
    // Start is called before the first frame update
    public void Back()
    {
        level.SetActive(false);
        menu.SetActive(true);
    }
}
