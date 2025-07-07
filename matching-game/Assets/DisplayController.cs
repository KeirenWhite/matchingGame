using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
    public void CreateDisplay()
    {
        /*for (int i = 0; i < displayList.Count; i++)
        {
            MatchDisplay dsp = Instantiate(displayPrefab, displayGridTransform);
            dsp.SetDisplaySprite(displaySprites[i]);
            dsp.displayController = this;
            //dsp.ShowDisplay();
        }*/
        MatchDisplay dsp = Instantiate(displayPrefab, displayGridTransform);
        dsp.SetDisplaySprite(displaySprites[0]);
        dsp.displayController = this;
        ogCanvas.SetActive(false);
        Continue();
        //continueButton.SetActive(true);
        

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
    }
}
