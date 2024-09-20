using UnityEngine;

public class changecolor : MonoBehaviour
{
    private Color originalColor;
    private Renderer rend;
    public SubTask subTask;
    public bool check;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    public bool ColorChange(){
        return check = true;
    }

    public bool NotColorChange(){
        return check = false;
    }

    void OnMouseEnter()
    {
        if(check){
            Color secondColor = new Color(0.3f, 0.3f, 0.3f, 0.5f); //transparent color

            rend.material.color = originalColor + secondColor;
        }
        
    }
    void OnMouseExit()
    {
        rend.material.color = originalColor;
    }
}
