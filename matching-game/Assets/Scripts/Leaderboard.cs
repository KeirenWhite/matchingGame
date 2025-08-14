using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    //public GameObject leaderboard;
    public Button leaderboardButton;
    public AudioSource audioSource;
    private void Start()
    {
        ToLeaderboard();
    }
    public void ToLeaderboard()
    {
        leaderboardButton.onClick.AddListener(() =>
        {
            audioSource.Play();          
            NextScene("Leaderboard");
        });
    }

    public void NextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
