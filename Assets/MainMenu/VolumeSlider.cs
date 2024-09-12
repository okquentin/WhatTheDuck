using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    [SerializeField] AudioMixer masterMixer;

    private void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("SavedMasterVolume", 100f));
    }

    public void SetVolume(float _value)
    {
        if (_value < 0.01f)
        {
            _value = 0.01f;
        }
        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedMasterVolume", _value);
        masterMixer.SetFloat("MasterVolume", Mathf.Log10(_value / 100) * 20f);
    }

    public void RefreshSlider(float _value)
    {
        soundSlider.value = _value;
    }
}