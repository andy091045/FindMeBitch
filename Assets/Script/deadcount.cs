using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deadcount : MonoBehaviour
{
    public Text bossWin_UI;
    public int dead = 0;
    // Start is called before the first frame update
    void Start()
    {
        bossWin_UI.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (dead >= 2)
        {
            bossWin_UI.text = "Boss Win!";
            Debug.Log("Boss Win");
        }
    }
}
