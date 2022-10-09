using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceBGM;
    public void Start()
    {
        audioSourceBGM.PlayDelayed(0.8f);
    }

}
