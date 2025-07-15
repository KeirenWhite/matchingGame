using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public float score = 0f;
    public float matchCounter = 0;
    public float scoreMult = 1.0f;
    public float baseScore = 10f;
    public float currentScoreMult;

    private void Update()
    {
        Debug.Log(score);
        Debug.Log(matchCounter);
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
