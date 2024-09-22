using UnityEngine;
using Holylib.HolySoundEffects;

public class Fridge : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private Vector2 boundary;
    private bool moving;
    private Vector2 resetPosition;
    [SerializeField] AudioClip MagnetSFX;

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
        SoundEffectController.PlaySFX(MagnetSFX).SetVolume(0.90f).RandomPitchRange(1.30f, 1.60f);
        moving = true;
        playerMovement.isLocked = true;
        //playerMovement.enabled = false;
    }
    public void OnMouseUp()
    {
        SoundEffectController.PlaySFX(MagnetSFX).SetVolume(0.90f).RandomPitchRange(0.90f, 1.10f);
        moving = false;
        playerMovement.UnlockMovement();
        //playerMovement.enabled = true;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        resetPosition = this.transform.localPosition;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        this.transform.localPosition = new Vector2(resetPosition.x, resetPosition.y);
    }

}


