﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToStage2 : MonoBehaviour
{
    public void OnLoginButtonClick()
    {
        Debug.Log("in");
        SceneManager.LoadScene(4);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("finish");
            Application.Quit();
        }
    }
}
