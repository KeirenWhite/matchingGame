using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    [SerializeField] MatchDisplay displayPrefab;
    Sprite[] displaySprites;
    [SerializeField] Transform displayGridTransform;
    [SerializeField] Transform displayTransform;
    private List<Sprite> displayList;
    public GameObject ogCanvas;
    public Button continueButtonPrefab;
    public Transform continueButtonTransform;
    public bool displayActive = false;
    [HideInInspector] public MatchDisplay currentDisplay;
    public EndGame endGame;
    public AudioSource audioSource;
    public AudioSource buttonAuidoSource;
    public GameObject gradient;
    private void Start()
    {
        //PrepareDisplays();
        //CreateDisplay();
    }

    private void PrepareDisplays()
    {
        displayList = new List<Sprite>();

        for (int i = 0; i < displaySprites.Length; i++)
        {          
            displayList.Add(displaySprites[i]);
            // add matchdisplay sprite here
        }
    }
    public MatchDisplay CreateDisplay(Sprite sprite, string text)
    {
        /*for (int i = 0; i < displayList.Count; i++)
        {
            MatchDisplay dsp = Instantiate(displayPrefab, displayGridTransform);
            dsp.SetDisplaySprite(displaySprites[i]);
            dsp.displayController = this;
            //dsp.ShowDisplay();
        }*/

        
        currentDisplay = Instantiate(displayPrefab, displayGridTransform);
        currentDisplay.SetDisplaySprite(sprite);
        currentDisplay.SetDisplayText(text);
        currentDisplay.displayController = this;
        endGame.matchesLeft -= 2;
        audioSource.Play();

        ogCanvas.SetActive(false);
        gradient.SetActive(false);
        Continue();

        return currentDisplay;


        
        

    }

    public void DestroyDisplay()
    {
        if(currentDisplay != null)
        {
            Destroy(currentDisplay.gameObject);
        }
        
    }

    public void Continue()
    {
        Button continueButton = Instantiate(continueButtonPrefab, continueButtonTransform);
        continueButton.onClick.AddListener(() =>
        {
            buttonAuidoSource.Play();
            Resume();
            endGame.EndTheGame();

            Destroy(continueButton.gameObject);
        });
        
    }

    public void Resume()
    {
        gradient.SetActive(true);
        ogCanvas.SetActive(true);
        DestroyDisplay();
        //displayActive = false;
        //CreateDisplay();
        
    }
}
