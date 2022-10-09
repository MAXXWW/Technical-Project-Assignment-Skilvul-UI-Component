using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    // public Slider BGMslider;
    // public Slider SFXslider;
    // public AudioMixer mixer;
    // [SerializeField] AudioSource audioSourceBGM;

    // public void StartMusic()
    // {
    //     audioSourceBGM.PlayDelayed(2f);
    //     float db;
    //     mixer.GetFloat("SFX_volume", out db);
    //     SFXslider.value = (db + 80) / 80;

    //     mixer.GetFloat("BGM_volume", out db);
    //     BGMslider.value = (db + 80) / 80;
    // }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void PrintBack(string pesan)
    {
        Debug.Log(pesan);
    }
}
