using UnityEngine;
using Holylib.HolySoundEffects;

public class ActionSFX : MonoBehaviour
{
    public AudioClip SFX;
    private void OnMouseDown() {
        SoundEffectController.PlaySFX(SFX);
    }
}
