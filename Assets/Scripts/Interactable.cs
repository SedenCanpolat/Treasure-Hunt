using UnityEngine;

public class Interactable : MonoBehaviour
{
    private static bool _isActive=true;
    public static bool isActive{
        get => _isActive; set{ _isActive = value; print(value);}
    }
}


