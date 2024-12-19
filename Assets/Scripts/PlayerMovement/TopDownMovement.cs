using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class TopDownMovement : MonoBehaviour
{
    public float speed = 5f;
    public float speedMultiplier = 2f;
    public float Speed;
    
    Vector3 movement;
    public Animator animator;
    [SerializeField] AudioClip walkSFX;
    SoundSource walksound;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Speed = speed;

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (movement.x != 0 || movement.y != 0)
        {

            if (0 > movement.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            if (0 < movement.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            if (!walksound)
            {
                walksound = SoundEffectController.PlaySFX(walkSFX).SetVolume(1.60f).RandomPitchRange(1.60f, 2.40f).SetLoop(true);
            }
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                Speed *= speedMultiplier;

            }
            float step = Speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, transform.position + movement * Speed, step);

            animator.SetBool("walk", true);

                    //transform.position = Vector2.MoveTowards(transform.position, transform.position + movement, step);
        }

        else animator.SetBool("walk", false);
    }
}
