using UnityEngine;

public class vfx_script : MonoBehaviour
{
    [SerializeField] GameObject Vfx;

    Vector2 mouse;
    void Start()
    {
        Vfx.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Mouse();
    }

    private void Mouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vfx.SetActive(true);
            Vfx.transform.position = new Vector3(mouse.x, mouse.y, 0f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vfx.SetActive(false);
        }
    }
}