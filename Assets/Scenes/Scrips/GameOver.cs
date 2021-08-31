using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text textGameOver;
    private bool inGame;
    void Start()
    {
        textGameOver.enabled = false;



        inGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (inGame)
        {
            GameObject PlayerObj = GameObject.Find("Player");
            if ( PlayerObj== null)
            {
                textGameOver.enabled = true;
            }
        }
    }
}
