using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;
using UnityEngine.UI;

public class ButtonSFX : MonoBehaviour
{
    [SerializeField] AudioClip BSFX;

    private void Start() {
        // GetComponent<Button>().onClick.AddListener(playSFX); // playSFX abone oldu onClick fonkisine
    }

    public void playSFX(){
        SoundEffectController.PlaySFX(BSFX);
    }
}
