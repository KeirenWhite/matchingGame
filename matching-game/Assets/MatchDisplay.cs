using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MatchDisplay : MonoBehaviour
{
    [SerializeField] Image matchDisplay;
    [SerializeField] TMP_Text matchDisplayText;
    public DisplayController displayController;

    public Sprite displaySprite;
    //public string displayText;

    public void SetDisplaySprite(Sprite dsp)
    {
        matchDisplay.sprite = dsp;
    }

    public void SetDisplayText(string text)
    {
        matchDisplayText.text = text;
    }
    /*public void ShowDisplay()
    {
        matchDisplay.sprite = displaySprite;
    }*/
}
