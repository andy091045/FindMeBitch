using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Territory : MonoBehaviour
{
    time happy;
    public Text ChanllengersWin_UI;
    private float timer = 0;
    private bool stay = false;
    public float beat = 6;
    public GameObject Chanllenger1;
    public GameObject Chanllenger2;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Chanllenger1" || col.name == "Chanllenger2")
        {
            stay = true;
            Debug.Log("on");
        }
    }

    void disappear()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "Chanllenger1" || col.name == "Chanllenger2")
        {
            Debug.Log("off");
            stay = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        // if (((Chanllenger1.transform.position.x >= -8 && Chanllenger1.transform.position.x <= -4) && (Chanllenger1.transform.position.y >= -4 && Chanllenger1.transform.position.y <= 0))
        // || ((Chanllenger2.transform.position.x >= -8 && Chanllenger2.transform.position.x <= -4) && (Chanllenger2.transform.position.y >= -4 && Chanllenger2.transform.position.y <= 0)))
        // {
        //     stay = true;
        // }
        // else
        // {
        //     stay = false;
        // }
        if (stay == true)
        {
            if (timer <= 7)
            {
                timer += Time.deltaTime;
                // Debug.Log(timer);
            }
            else
            {
                ChanllengersWin_UI.text = "Chanllengers Win!";
                // happy.stop(1);
                Debug.Log("setactive=0");
                disappear();
                // Destroy(gameObject);
                timer = 0;
            }
        }
        else
        {
            timer = 0;
        }
    }
}
