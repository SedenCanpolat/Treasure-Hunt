using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public Image actorImage;
    public TMP_Text actorName;
    public TMP_Text messageText;
    public RectTransform backgroundBox; // for animation
    public GameObject player;


    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        player.GetComponent<PlayerMovement>().enabled = false;

        DisplayMessage();
        Debug.Log("Started conversation! Loaded messages: " + messages.Length);

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
            Debug.Log("Conversation eneded!");
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo(); //ending the conversation animation
            isActive = false;
            player.GetComponent<PlayerMovement>().enabled = true;
        }
        activeMessage++;

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
