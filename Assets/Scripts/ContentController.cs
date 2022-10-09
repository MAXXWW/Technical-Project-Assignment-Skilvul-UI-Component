using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour
{
    public void ValChangedButton(float value)
    {
        Debug.Log("Button Size : " + value);
    }

    public void ValChangedSensitivity(float value)
    {
        Debug.Log("Sensitivity : " + value);
    }
}
