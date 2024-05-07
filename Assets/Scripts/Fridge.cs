using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private bool moving;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            Vector2 mousePos;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y);
        }
    }
    private void OnMouseDown()
    {
        moving = true;
        playerMovement.enabled = false;
    }
    public void OnMouseUp()
    {
        moving = false;
        playerMovement.enabled = true;
    }



}
