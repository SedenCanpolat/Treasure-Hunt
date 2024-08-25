using UnityEngine;
using Holylib.HolySoundEffects;


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
