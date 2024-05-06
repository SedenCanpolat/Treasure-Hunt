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
        mainAudioMixer.SetFloat("Master", volume);
        PlayerPrefs.SetFloat("MasterVolume", volume); 
        PlayerPrefs.Save(); 
    }

    public void ChangeMusicVolume()
    {
        float volume = musicVol.value;
        mainAudioMixer.SetFloat("Music", volume);
        PlayerPrefs.SetFloat("MusicVolume", volume); 
        PlayerPrefs.Save(); 
    }

    public void ChangeSfxVolume()
    {
        float volume = sfxVol.value;
        mainAudioMixer.SetFloat("SFX", volume);
        PlayerPrefs.SetFloat("SFXVolume", volume); 
        PlayerPrefs.Save(); 
    }

    private void LoadSettings()
    {
        masterVol.value = PlayerPrefs.GetFloat("MasterVolume");
        musicVol.value = PlayerPrefs.GetFloat("MusicVolume");
        sfxVol.value = PlayerPrefs.GetFloat("SFXVolume");
        
        ChangeMasterVolume();
        ChangeMusicVolume();
        ChangeSfxVolume();
    }
}
