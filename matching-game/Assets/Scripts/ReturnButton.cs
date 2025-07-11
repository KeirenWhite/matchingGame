using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReturnButton : MonoBehaviour
{
    public Button returnButton;
    private void Start()
    {
        RestartGame();
    }
    public void RestartGame()
    {
        returnButton.onClick.AddListener(() =>
        {
            NextScene("StartScreen");
        });
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}