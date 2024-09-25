using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Holylib.HolySoundEffects;

public class DialogManager : MonoBehaviour
{
    public Image actorImage;
    public TMP_Text actorName;
    public TMP_Text messageText;
    public RectTransform backgroundBox; // for animation
    public GameObject player;
    [SerializeField] AudioClip DialogSFX;
    private LeanBreathing leanBreathing;


    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false; // singleton also can be used   

    public async void OpenDialogue(Message[] messages, Actor[] actors, int waitms=0)
    {
        Interactable.isActive = false;
        
        
        player.GetComponent<PlayerMovement>().LockMovement();
        await System.Threading.Tasks.Task.Delay(waitms);
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        DisplayMessage();
        //Debug.Log("Started conversation! Loaded messages: " + messages.Length);

        backgroundBox.LeanScale(Vector3.one, 0.5f).setEaseInExpo(); //open dialogue
    }



    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;
        

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        AnimateTextColor();
    }


    public void NextMessage()
    {

        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            FinishDialog();
        }
        activeMessage++;
        SoundEffectController.PlaySFX(DialogSFX).SetVolume(0.06f).SetPitch(Random.Range(0.7f, 1f));
    }

    public void FinishDialog()
    {
        if(isActive){
            Interactable.isActive = true;
            //Debug.Log("Conversation eneded!");
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo(); //ending the conversation animation
            isActive = false;
            player.GetComponent<PlayerMovement>().UnlockMovement();
            if (leanBreathing != null)
            {
                leanBreathing.StopBreathing();
            }
        }
    }

    void AnimateTextColor() //change the text transparency
    {
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }


    // Start is called before the first frame update
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero; //dialoguebox dont open in the start
        leanBreathing = FindObjectOfType<LeanBreathing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isActive == true)
        {
            NextMessage();
        }

    }
}
