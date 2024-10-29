using UnityEngine;
using Holylib.HolySoundEffects;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    public float xRange;
    public float yRange;
    Vector2 lastClickedPos;
    bool moving;

    public Animator animator;

    private int lockCount = 0;
    [SerializeField] AudioClip walkSFX;
    SoundSource walksound;

    [SerializeField] LayerMask groundmMask;

    private void Start()
    {
        FindObjectOfType<SettingOpenClose>().onsettingOpenAction += LockMovement;
        FindObjectOfType<SettingOpenClose>().onsettingCloseAction += UnlockMovement;
    }

    void Update()
    {
        //if(lockCount > 0)   return;
        if (isLocked)
        {
            animator.SetBool("walk", false);
            return;
        }
        //if (DialogManager.isActive == true) //if dialogue is open, then character not moving
        //return;

        //if (Input.GetMouseButtonDown(0) && floorScript.check)
        if (isPointerOnGround && Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            if (0 > (lastClickedPos.x - transform.position.x))
                transform.localScale = new Vector3(-1, 1, 1);

            if (0 < (lastClickedPos.x - transform.position.x))
                transform.localScale = new Vector3(1, 1, 1);

            if (!walksound)
                walksound = SoundEffectController.PlaySFX(walkSFX).SetVolume(1.60f).RandomPitchRange(1.60f, 2.40f).SetLoop(true);

            animator.SetBool("walk", true);

            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
        }
        else
        {
            moving = false;
            CancelMovement();
        }
    }

    bool isPointerOnGround
    { // statement
        get
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, groundmMask);

            return hit.collider != null;
        }
    }

    public bool isLocked
    {
        // getter setter
        get
        {
            return lockCount > 0;
        }
        set
        {
            if (value == true)
            {
                lockCount++;
                CancelMovement();
            }
            else
            {
                lockCount--;
            }
        }
        // only I can take(get) its value, I cannot put(set) value inside of it 
    }



    public void LockMovement()
    {
        lockCount++;
        CancelMovement();
    }

    public void UnlockMovement()
    {
        lockCount--;
    }

    void CancelMovement()
    {
        if (walksound)
        {
            SoundEffectController.StopSFX(walksound);
            walksound = null;
        }
        animator.SetBool("walk", false);
    }

}