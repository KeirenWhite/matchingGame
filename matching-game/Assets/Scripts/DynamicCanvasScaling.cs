using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicCanvasScaling : MonoBehaviour
{
    public CanvasScaler scaler;
    public GameObject companyLogo;

    private void FixedUpdate()
    {
        float aspectRatio = (float)Screen.width / Screen.height;

        if (aspectRatio < 1f)
        {         
            scaler.matchWidthOrHeight = .5f;
            //companyLogo.SetActive(true);
        }
        else if (aspectRatio >= 3f)
        {
            scaler.matchWidthOrHeight = 0f;
            //companyLogo.SetActive(false);
        }
        else
        {
            scaler.matchWidthOrHeight = 0f;
            //companyLogo.SetActive(true);
        }
    }
}
