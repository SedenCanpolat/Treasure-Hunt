using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.HolySoundEffects;

public class TopDownMovementDeneme : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
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
            animator.SetBool("walk", true);
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, transform.position + movement, step);
        }

        else animator.SetBool("walk", false);

    }
}
