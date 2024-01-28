using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnLevelBonus : MonoBehaviour
{
    public void PlayLevel()
    {
        GameManager.instance.PlayBonus();
    }
}
