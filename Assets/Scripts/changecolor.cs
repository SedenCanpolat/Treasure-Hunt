using UnityEngine;

public class changecolor : MonoBehaviour
{
    private Color originalColor;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        Color secondColor = new Color(0.3f, 0.3f, 0.3f, 0.5f); //transparent color

        rend.material.color = originalColor + secondColor;
    }
    void OnMouseExit()
    {
        rend.material.color = originalColor;
    }
}
