using UnityEngine;
using Holylib.HolySoundEffects;

public class MainManager : MonoBehaviour
{
    private void Awake() {
        if(!PlayerPrefs.HasKey("MasterVolume")) PlayerPrefs.SetFloat("MasterVolume", 0.5f);
        if(!PlayerPrefs.HasKey("MusicVolume")) PlayerPrefs.SetFloat("MusicVolume", 0.5f);
        if(!PlayerPrefs.HasKey("SFXVolume")) PlayerPrefs.SetFloat("SFXVolume", 0.5f);
        SoundEffectController.SFXVolume = PlayerPrefs.GetFloat("SFXVolume");
        SoundEffectController.MusicVolume = PlayerPrefs.GetFloat("MusicVolume");
        SoundEffectController.MasterVolume = PlayerPrefs.GetFloat("MasterVolume");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
