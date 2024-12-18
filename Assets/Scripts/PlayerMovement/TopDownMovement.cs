using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class TopDownMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    public float speedMultiplier = 1.5;
    //public float ShiftSpeed = 5f;
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

        public float Speed = speed;
    movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        if (movement.x != 0 || movement.y != 0)
        {
            float step = speed * Time.deltaTime;
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
if (Input.GetKey(KeyCode.LeftShift))
{
    Speed *= speedMultiplier;

}
step = Speed * Time.deltaTime;
transform.position = Vector2.MoveTowards(transform.position, transform.position + movement * speedMultiplier * speed, step);

animator.SetBool("walk", true);

            //transform.position = Vector2.MoveTowards(transform.position, transform.position + movement, step);
        }

        else animator.SetBool("walk", false);
    }
}
lkdlkeldkl