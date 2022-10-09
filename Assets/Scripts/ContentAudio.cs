using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentAudio : MonoBehaviour
{
    public void ValChangedBGM(float value)
    {
        Debug.Log("Volume BGM : " + value);
    }

    public void ValChangedSFX(float value)
    {
        Debug.Log("Volume SFX : " + value);
    }
}
