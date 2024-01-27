using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public Text hint; 
    public int seen = 4;

    private void Start()
    {
        hint.text = "Hewan Berkaki 2 <color=#00000000>, Suka Makan Kacang , Berbulu tebal, Bermata 2, Suka memanjat pohon </color>";
    }
    public void Seen()
    {
        if (seen>3 && seen<5)
        {
            hint.text = "Hewan Berkaki 2, Suka Makan Kacang  <color=#00000000>, Berbulu tebal, Bermata 2, Suka memanjat pohon</color>";
            seen--;
        }
        else if (seen>2 && seen<4)
        {
            hint.text = "Hewan Berkaki 2, Suka Makan Kacang , Berbulu tebal<color=#00000000>, Bermata 2, Suka memanjat pohon</color>";
            seen--;
        }
        else if (seen>1 && seen<3) 
        {
            hint.text = "Hewan Berkaki 2, Suka Makan Kacang , Berbulu tebal , Bermata 2 <color=#00000000>, Suka memanjat pohon </color>";
            seen--;
        }
        else if (seen>0 && seen<2)
        {
            hint.text = "Hewan Berkaki 2, Suka Makan Kacang , Berbulu tebal , Bermata 2 , Suka memanjat pohon";
            seen--;
        }
    }
}
