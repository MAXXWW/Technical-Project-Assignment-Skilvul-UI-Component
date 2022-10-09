using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerGroupVolume : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] string parameter;
    // [SerializeField, Range(0, 1f)] float volume = 1f;

    // public void Update()
    // {
    //     audioMixer.SetFloat(parameter, LinearToDecibel(volume));
    // }

    public void UpdateValue(float volumeOri)
    {
        audioMixer.SetFloat(parameter, LinearToDecibel(volumeOri));
    }

    public float LinearToDecibel(float linear)
    {
        linear = Mathf.Clamp(linear, 0.0001f, 1);
        return 20 * Mathf.Log10(linear);
    }
}
