using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchDisplay : MonoBehaviour
{
    [SerializeField] Image matchDisplay;
    public DisplayController displayController;

    public Sprite displaySprite;

    public void SetDisplaySprite(Sprite dsp)
    {
        matchDisplay.sprite = dsp;
    }
    /*public void ShowDisplay()
    {
        matchDisplay.sprite = displaySprite;
    }*/
}
