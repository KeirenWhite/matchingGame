using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    [SerializeField] MatchDisplay displayPrefab;
    [SerializeField] Sprite[] displaySprites;
    [SerializeField] Transform displayGridTransform;
    private List<Sprite> displayList;
    public GameObject ogCanvas;
    public Button continueButtonPrefab;
    public Transform continueButtonTransform;
    public bool displayActive = false;
    private MatchDisplay currentDisplay;
    private void Start()
    {
        PrepareDisplays();
        //CreateDisplay();
    }

    private void PrepareDisplays()
    {
        displayList = new List<Sprite>();

        for (int i = 0; i < displaySprites.Length; i++)
        {
            // adding sprite 2 times to make it a pair
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
        
        
        ogCanvas.SetActive(false);
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
            Resume();
            Destroy(continueButton.gameObject);
        });
        
    }

    public void Resume()
    {
        ogCanvas.SetActive(true);
        DestroyDisplay();
        //displayActive = false;
        //CreateDisplay();
        
    }
}
