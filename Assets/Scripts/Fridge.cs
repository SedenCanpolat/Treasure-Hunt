using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private Vector2 boundary;
    private bool moving;


    void Start()
    {
        boundary = this.transform.parent.localScale;
    }
    void Update()
    {
        if (moving)
        {
            Vector2 mousePos;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //Debug.Log(Mathf.Abs(this.transform.parent.position.x - mousePos.x));

            if (Mathf.Abs(this.transform.parent.position.x - mousePos.x) <= boundary.x / 2 &&
                Mathf.Abs(this.transform.parent.position.y - mousePos.y) <= boundary.y / 2)
            {
                this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y);
            }

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
