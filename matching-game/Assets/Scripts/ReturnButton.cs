using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public Button returnButton;
    public ScoreSystem score;
    public AudioSource audioSource;
    private void Start()
    {
        RestartGame();
    }
    public void RestartGame()
    {
        returnButton.onClick.AddListener(() =>
        {
            audioSource.Play();
            score.score = 0f;
            NextScene("StartScreen");
        });
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}