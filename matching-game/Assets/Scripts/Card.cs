using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PrimeTween;

public class Card : MonoBehaviour
{
    [SerializeField] private Image iconImage;

    public Sprite hiddenIconSprite;
    public Sprite iconSprite;
    public CardsController controller;
    //public EndGame endGame;

    public void OnCardClick()
    {
        controller.SetSelected(this);
    }

    public bool isSelected;


    public void SetIconSprite(Sprite sp)
    {
        iconSprite = sp;
        //endGame.matchesLeft++;
    }

    public void Show()
    {
        Tween.Rotation(transform, new Vector3(0f, 180f, 0f), .2f);

        Tween.Delay(.1f, () => iconImage.sprite = iconSprite);

        //iconImage.sprite = iconSprite;
        isSelected = true;
    }

    public void Hide()
    {
        Tween.Rotation(transform, new Vector3(0f, 0f, 0f), .2f);

        Tween.Delay(0.1f, () => 
        {
            iconImage.sprite = hiddenIconSprite; 
            isSelected = false;
        });
        

        //iconImage.sprite = hiddenIconSprite;
        //isSelected = false;
    }
}
