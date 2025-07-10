using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DynamicDisplayScaling : MonoBehaviour
{
    public GameObject contButtonTransform;
    public RectTransform contButtonRectTransform;
    public DisplayController displayController;
    public GridLayoutGroup grid;
    public GameObject companyLogo;
    public CanvasScaler displayCanvasScaler;

    private float scaleX = 3.1f;
    private float scaleY = 6.8f;
    private float scaleZ = 1.0f;

    private float displayScale = 1f;
    private float continueScale = 2.8f;

    public float scaleFactor = .3f;
    public float scaleFactor2 = .2f;
    public float displayScaleFactor = .5f;
    public float displayScaleFactor2 = .35f;
    public Vector2 startAnchoredPosition;
    public float contButtonAnchoredPositionY;
    public float contButtonAnchoredPositionX;

    private void Start()
    {
        startAnchoredPosition.x = contButtonRectTransform.anchoredPosition.x;
        startAnchoredPosition.y = contButtonRectTransform.anchoredPosition.y;
    }
    void FixedUpdate()
    {
        float aspectRatio = (float)Screen.width / Screen.height;

        /*if (displayController.currentDisplay == null)
        {
            return;
        }
        else
        {
            if (aspectRatio >= .8f && aspectRatio < 2f)
            {
                *//*displayController.currentDisplay.transform.localScale = new Vector3(scaleX * displayScaleFactor, scaleY * displayScaleFactor, scaleZ * displayScaleFactor);
                contButtonTransform.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
                //grid.padding.bottom = 300;
                contButtonRectTransform.anchoredPosition = new Vector2(startAnchoredPosition.x, startAnchoredPosition.y);
                companyLogo.SetActive(true);*//*
            }
            else if (aspectRatio >= 2f && aspectRatio < 3f)
            {
                displayController.currentDisplay.transform.localScale = new Vector3(scaleX * displayScaleFactor2, scaleY * displayScaleFactor2, scaleZ * displayScaleFactor2);
                contButtonTransform.transform.localScale = new Vector3(scaleFactor2, scaleFactor2, scaleFactor2);
                //grid.padding.bottom = 200;
                contButtonRectTransform.anchoredPosition = new Vector2(startAnchoredPosition.x + contButtonAnchoredPositionX, startAnchoredPosition.y + contButtonAnchoredPositionY);
                companyLogo.SetActive(true);
            }
            else if (aspectRatio >= 3f)
            {
                companyLogo.SetActive(false);
            }
            else
            {
                displayController.currentDisplay.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
                contButtonTransform.transform.localScale = new Vector3(displayScale, displayScale, displayScale);
                //grid.padding.bottom = 450;
                contButtonRectTransform.anchoredPosition = new Vector2(startAnchoredPosition.x, startAnchoredPosition.y);
                companyLogo.SetActive(true);
            }
        }*/

    }
}
