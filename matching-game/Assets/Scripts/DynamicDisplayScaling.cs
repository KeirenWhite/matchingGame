using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicDisplayScaling : MonoBehaviour
{
    public GameObject contButtonTransform;
    public DisplayController displayController;
    public GridLayoutGroup grid;

    private float scaleX = 3.1f;
    private float scaleY = 6.8f;
    private float scaleZ = 1.0f;

    private float displayScale = 1f;
    private float continueScale = 2.8f;

    public float scaleFactor = .3f;
    public float displayScaleFactor = .5f;
    void FixedUpdate()
    {
        float aspectRatio = (float)Screen.width / Screen.height;
        if (displayController.currentDisplay == null)
        {
            return;
        }
        else
        {
            if (aspectRatio > 1.5f)
            {
                displayController.currentDisplay.transform.localScale = new Vector3(scaleX * displayScaleFactor, scaleY * displayScaleFactor, scaleZ * displayScaleFactor);
                contButtonTransform.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
                grid.padding.bottom = 300;
            }
            else
            {
                displayController.currentDisplay.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
                contButtonTransform.transform.localScale = new Vector3(displayScale, displayScale, displayScale);
                grid.padding.bottom = 450;
            }
        }
        
    }
}
