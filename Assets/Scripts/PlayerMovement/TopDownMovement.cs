using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    //components
    public Rigidbody2D rb;

    //Player
    float walkSpeed = 4f;
    float speedLimiter = 0.7f;
    float inputHorizontal;
    float inputVertical;

    //Animations and states
    public Animator animator;


    //Sounds
    //[SerializeField] AudioClip walkSFX;
    //SoundSource walksound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        if (inputHorizontal != 0 || inputVertical != 0)
        {
            if (inputHorizontal != 0 && inputVertical != 0)
            {
                inputHorizontal *= speedLimiter;
                inputVertical *= speedLimiter;
            }
            if (inputHorizontal > 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            if (inputHorizontal < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);
            animator.SetBool("walk", true);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
            animator.SetBool("walk", false);

        }


    }











}
