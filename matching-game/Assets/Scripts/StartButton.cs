using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;
    private void Start()
    {
        StartGame();
    }
    public void StartGame()
    {
        startButton.onClick.AddListener(() =>
        {
            NextScene("GameScene");
        });
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
