using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorController : MonoBehaviour
{
    public Texture2D cursorDefault;   
    public Texture2D cursorHover;      

    private void Awake()
    {
        ChangeCursor(cursorDefault); 
        //Cursor.lockState = CursorLockMode.Confined;
    }

    private void ChangeCursor(Texture2D cursorType)
    {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }

    private void OnMouseEnter()
    {
        ChangeCursor(cursorHover);
    }
    private void OnMouseExit()
    {
        ChangeCursor(cursorDefault);
    }
}

