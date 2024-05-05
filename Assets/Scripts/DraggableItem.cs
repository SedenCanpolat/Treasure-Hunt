using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableItem : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject correctForm;
    private bool moving;
    private bool finish;
    private Vector2 resetPosition;
    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector2 mousePos;
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                this.gameObject.transform.position = new Vector3(mousePos.x, mousePos.y);
            }
        }
    }

    private void OnMouseDown()
    {
        playerMovement.enabled = false;
        moving = true;
    }

    public void OnMouseUp()
    {
        playerMovement.enabled = true;
        moving = false;

        if (Mathf.Abs(this.transform.position.x - correctForm.transform.position.x) <= 2f &&
            Mathf.Abs(this.transform.position.y - correctForm.transform.position.y) <= 2f)
        {
            this.transform.position = new Vector2(correctForm.transform.position.x, correctForm.transform.position.y);
            finish = true;

        }
        else
        {
            this.transform.localPosition = new Vector2(resetPosition.x, resetPosition.y);
        }
    }

}
