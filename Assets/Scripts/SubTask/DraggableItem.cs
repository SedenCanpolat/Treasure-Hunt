using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class DraggableItem : MonoBehaviour
{
    public SubTask subTask;
    public DialogTrigger dialogTrigger;
    public PlayerMovement playerMovement;
    public GameObject correctForm;
    private bool moving;
    private bool finish;
    private Vector2 resetPosition;

    [SerializeField] AudioClip ClothSFX;

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
        if (dialogTrigger.dialogIndex > 0)
        {
            SoundEffectController.PlaySFX(ClothSFX);
            moving = true;
            playerMovement.enabled = false;
        }
    }

    public void OnMouseUp()
    {
        moving = false;
        playerMovement.enabled = true;

        if (Mathf.Abs(this.transform.position.x - correctForm.transform.position.x) <= 2f &&
            Mathf.Abs(this.transform.position.y - correctForm.transform.position.y) <= 2f)
        {
            this.transform.position = new Vector2(correctForm.transform.position.x, correctForm.transform.position.y);
            finish = true;
            subTask.clothesNum--;
            //Debug.Log(clothesNum);
            if (subTask.clothesNum == 0) dialogTrigger.dialogIndex = 2;

        }
        else
        {
            this.transform.localPosition = new Vector2(resetPosition.x, resetPosition.y);
        }
    }

}
