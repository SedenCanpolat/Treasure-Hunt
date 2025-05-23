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
    [SerializeField] AudioClip PutSFX;
    [SerializeField] AudioClip CompleteSFX;

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

    private void OnMouseEnter()
    {
        if (dialogTrigger.dialogIndex == subTask.task[0].getTask + 1)
        {
            GetComponent<changecolor>().ColorChange();
        }
    }

    private void OnMouseDown()
    {
        if (dialogTrigger.dialogIndex == subTask.task[0].getTask + 1)
        {
            SoundEffectController.PlaySFX(ClothSFX).RandomPitchRange(0.90f, 1.10f);
            moving = true;

        }
        playerMovement.isLocked = true;
    }

    public void OnMouseUp()
    {
        moving = false;
        playerMovement.UnlockMovement();
        float pitchRangeNum = 0.60f;

        if (Mathf.Abs(this.transform.position.x - correctForm.transform.position.x) <= 2f &&
            Mathf.Abs(this.transform.position.y - correctForm.transform.position.y) <= 2f)
        {
            this.transform.position = new Vector2(correctForm.transform.position.x, correctForm.transform.position.y);
            finish = true;
            subTask.clothesNum--;
            pitchRangeNum += 0.20f;
            SoundEffectController.PlaySFX(PutSFX).SetPitch(pitchRangeNum);
            this.gameObject.SetActive(false);


            if (subTask.clothesNum == 0)
            {
                SoundEffectController.PlaySFX(CompleteSFX).SetVolume(0.50f);
                dialogTrigger.dialogIndex++;
                GetComponent<changecolor>().NotColorChange();
            }
        }
        else
        {
            this.transform.localPosition = new Vector2(resetPosition.x, resetPosition.y);
        }
    }

}
