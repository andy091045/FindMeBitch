using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public int bossAttackTime = 25;
    public Text BossAttackTime;
    public Text BossLose;

    public void UpdateText()
    {
        bossAttackTime --;
        BossAttackTime.text = bossAttackTime + "";
        if (bossAttackTime <= 0)
        {
            BossLose.text = "Chanllengers Win!";
        }
    }

    public void OnEnable()
    {
        Boss.onAttack += UpdateText;
    }
}
