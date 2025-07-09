using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicCanvasScaling : MonoBehaviour
{
    public CanvasScaler scaler;

    private void FixedUpdate()
    {
        float aspectRatio = (float)Screen.width / Screen.height;

        if (aspectRatio < 1f)
        {         
            scaler.matchWidthOrHeight = .5f;
        }
        else
        {
            scaler.matchWidthOrHeight = 0f;
        }
    }
}
