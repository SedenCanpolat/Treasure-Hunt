using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class settingsmenu : MonoBehaviour
{
    public TMP_Dropdown graphicsDropdown;
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer mainAudioMixer;

    private void Start()
    {
        LoadSettings();
    }

    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }

    public void ChangeMasterVolume()
    {
        float volume = masterVol.value;
        PlayerPrefs.SetFloat("MasterVolume", volume); 
        PlayerPrefs.Save();
        volume = Mathf.Log10(volume) * 20;
        mainAudioMixer.SetFloat("MasterVolume", volume);
         
    }

    public void ChangeMusicVolume()
    {
        float volume = musicVol.value;
        PlayerPrefs.SetFloat("MusicVolume", volume); 
        PlayerPrefs.Save();
        volume = Mathf.Log10(volume) * 20;
        mainAudioMixer.SetFloat("MusicVolume", volume);
         
    }

    public void ChangeSfxVolume()
    {
        float volume = sfxVol.value;
        PlayerPrefs.SetFloat("SFXVolume", volume); 
        PlayerPrefs.Save(); 
        volume = Mathf.Log10(volume) * 20;
        mainAudioMixer.SetFloat("SFXVolume", volume);
    }

    public void LoadSettings()
    {
        masterVol.value = PlayerPrefs.GetFloat("MasterVolume");
        musicVol.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxVol.value = PlayerPrefs.GetFloat("SFXVolume");
        
        ChangeMasterVolume();
        ChangeMusicVolume();
        ChangeSfxVolume();
    }
}
