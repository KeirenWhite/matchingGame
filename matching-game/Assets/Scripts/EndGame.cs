using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    public int matchesLeft = 0;
    public GameObject gameCanvas;
    public GameObject endCanvas;
    public GameObject ogCanvas;
    public GameObject displayCanvas;
    

    
    public void EndTheGame()
    {
        if (matchesLeft <= 0)
        {
            gameCanvas.SetActive(false);
            endCanvas.SetActive(true);
            ogCanvas.SetActive(false);
            displayCanvas.SetActive(false);
        }
    }

    
    /*private void RestartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }*/
}
