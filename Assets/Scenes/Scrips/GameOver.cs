using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private AudioSource audioSource;
    public Text textGameOver;
    private bool inGame;
    [SerializeField]private AudioClip overSound;
    void Start()
    {
        textGameOver.enabled = false;

        
        audioSource = gameObject.AddComponent<AudioSource>();



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
                audioSource.PlayOneShot(overSound);
                textGameOver.enabled = true;
               
                inGame = false;
            }
        }
    }
}
