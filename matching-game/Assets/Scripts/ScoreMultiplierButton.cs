using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreMultiplierButton : MonoBehaviour
{
    public ScoreSystem scoreSystem;
    public Button multButton;
    public bool multButtonSelected = false;
    public AudioSource audioSource;

    public void Awake()
    {
        MultScore();
    }

    
    public void MultScore()
    {
        multButton.onClick.AddListener(() =>
        {
            //multButtonSelected = true;
            if (!multButtonSelected)
            {
                multButtonSelected = true;
                audioSource.Play();
                multButton.gameObject.SetActive(false);
            }
            /*else
            {
                multButtonSelected = false;
            }
            */
        });
    }
    
}
