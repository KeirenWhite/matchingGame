using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public float score = 0f;
    public float matchCounter = 0;
    public float scoreMult = 1.0f;
    public float baseScore = 10f;
    public float currentScoreMult;
    public TMP_Text scoreText;
    public TMP_Text streakText;
    public TMP_Text endScoreText;

    private void FixedUpdate()
    {
        Debug.Log(score);
        Debug.Log(matchCounter);
        UpdateCounterDisplay();
    }

    public void UpdateCounterDisplay()
    {
        scoreText.text = string.Format("Score: {0}", score);
        streakText.text = string.Format("Streak: {0}", matchCounter);
        endScoreText.text = string.Format("{0}", score);
    }

    public void ScoreMultiplier()
    {
        if (matchCounter == 0)
        {
            currentScoreMult = 1f;
        }
        else
        {
            currentScoreMult = (scoreMult *= matchCounter);
        }
       
        score += (baseScore * currentScoreMult);
    }
}
