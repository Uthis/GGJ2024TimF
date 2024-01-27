using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public Text hint; 
    public int seen = 3;
    public Image tebakan;
    public Sprite level1Sprite;
    public Sprite level2Sprite;
    public Sprite level3Sprite;
    public Sprite level4Sprite;
    public Sprite level5Sprite;
    private int level;

    void Start()
    {
        level = PlayerPrefs.GetInt("LevelNumber");

        switch (level)
        {
            case 1:
                tebakan.sprite = level1Sprite;
                SeenLevel1();
                break;
            case 2:
                tebakan.sprite = level2Sprite;
                SeenLevel2();
                break;
            case 3:
                tebakan.sprite = level3Sprite;
                SeenLevel3();
                break;
            case 4:
                tebakan.sprite = level4Sprite;
                SeenLevel4();
                break;
            case 5:
                tebakan.sprite = level5Sprite;
                SeenLevel5();
                break;
        }
    }
    public void SeenLevel1()
    {
        if (seen == 3)
        {
            hint.text = "Berwarna Hitam dan putih , Karnivora<color=#00000000>, Suka ikan, Berbulu</color>";
            seen--;
        }
        else if (seen == 2)
        {
            hint.text = "Berwarna Hitam dan putih, Karnivora, Suka ikan <color=#00000000>, Berbulu</color>";
            seen--;
        }
        else if (seen == 1)
        {
            hint.text = "Berwarna Hitam dan putih, Karnivora, suka ikan , berbulu";
            seen--;
        }
    }
    public void SeenLevel2()
    {
        if (seen == 3)
        {
            hint.text = "Larinya cepat, Berhabitat di daratan <color=#00000000>, Herbivora , Bersahabat dengan manusia </color>";
            seen--;
        }
        else if (seen == 2)
        {
            hint.text = "Larinya cepat , Berhabitat di daratan , Herbivora<color=#00000000>, Bersahabat dengan manusia</>";
            seen--;
        }
        else if (seen == 1)
        {
            hint.text = "Larinya cepat , Berhabitat di daratan , Herbivora , Bersahabat dengan manusia";
            seen--;
        }
    }
    public void SeenLevel3()
    {
        if (seen == 3)
        {
            hint.text = "Memiliki 4 kaki<color=#00000000>, Bisa menjadi hewan peliharaan, Berhabitat di darat dan laut, bernapas dengan paru paru </color>";
            seen--;
        }
        else if (seen == 2)
        {
            hint.text = "Memiliki 4 kaki, Bisa menjadi hewan peliharaan<color=#00000000>, Berhabitat di darat dan laut, bernapas dengan paru paru </color>";
            seen--;
        }
        else if (seen == 1)
        {
            hint.text = "Memiliki 4 kaki, Bisa menjadi hewan peliharaan, Berhabitat di darat dan laut<color=#00000000>, bernapas dengan paru paru </color>";
            seen--;
        }
    }
    public void SeenLevel4()
    {
        if (seen == 3)
        {
            hint.text = "Amvibi<color=#00000000>, Memiliki 4 kaki , Carnivora , Bertelur </color>";
            seen--;
        }
        else if (seen == 2)
        {
            hint.text = "Amvibi, Memiliki 4 kaki<color=#00000000>, Carnivora , Bertelur</color>";
            seen--;
        }
        else if (seen == 1)
        {
            hint.text = "Amvibi , Memiliki 4 kaki , Carnivora<color=#00000000>, Bertelur </color>";
            seen--;
        }
    }
    public void SeenLevel5()
    {
        if (seen == 3)
        {
            hint.text = "Hidup di darat , Carnivora <color=#00000000>, Dapat berlari kencang , Berbadan besar</color>";
            seen--;
        }
        else if (seen == 2)
        {
            hint.text = "Hidup di darat , Dapat berlari kencang <color=#00000000>, Berbadan besar</color>";
            seen--;
        }
        else if (seen == 1)
        {
            hint.text = "Hidup di darat , Carnivora , Dapat berlari kencang , Berbadan besar";
            seen--;
        }
    }
}
