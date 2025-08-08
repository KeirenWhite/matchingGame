using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScoreSystem : MonoBehaviour
{
    public float score = 0f;
    public float matchCounter = 0f;
    public float scoreMult = 1.0f;
    public float baseScore = 10f;
    public float currentScoreMult;
    public TMP_Text scoreText;
    public TMP_Text streakText;
    public TMP_Text endScoreText;
    public ScoreMultiplierButton scoreMultiplierButton;

   

    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    private void FixedUpdate()
    {
        Debug.Log(score);
        Debug.Log(matchCounter);
        UpdateCounterDisplay();
    }

    public void UpdateCounterDisplay()
    {
        scoreText.text = string.Format("SCORE: {0}", score);
        streakText.text = string.Format("STREAK: {0}", matchCounter);
        endScoreText.text = string.Format("{0}", score);
    }

    public void ScoreMultiplier()
    {
        currentScoreMult = 1f;
        if (matchCounter == 0f)
        {
            currentScoreMult = 1f;
        }
        else if (matchCounter == 1f)
        {
            currentScoreMult = 1f;
        }
        else 
        {
            currentScoreMult = matchCounter;
        }

        if (scoreMultiplierButton.multButtonSelected)
        {
            score += (baseScore * currentScoreMult) * 2;
            scoreMultiplierButton.multButtonSelected = false;
            //scoreMultiplierButton.multButton.gameObject.SetActive(false);
        }
        else
        {
            score += (baseScore * currentScoreMult);
        }      
    }

}
