using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    public int matchesLeft = 0;

    

    
    public void EndTheGame()
    {
        if (matchesLeft <= 0)
        {
            RestartGame("EndScreen");
        }
    }

    
    private void RestartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
