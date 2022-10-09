using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    private int score = 0;

    public void GetScore()
    {
        text.SetText($"Score : {score += 1}");
    }
}
