using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    int time_int = 120;

    public Text time_UI;
    public Text time1_UI;

    void Start()
    {
        stop(0);
        InvokeRepeating("timer", 1, 1);

    }

    public void timer()
    {

        time_int -= 1;

        time_UI.text = time_int + "";

        if (time_int == 0)
        {

            time_UI.text = "time\nup";
            time1_UI.text = "Boss Win!";

            CancelInvoke("timer");

        }

    }
    public void stop(int n)
    {
        if (n == 1)
        {
            Debug.Log("time up");

        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("finish");
            CancelInvoke("timer");
            Application.Quit();
        }
    }
}
