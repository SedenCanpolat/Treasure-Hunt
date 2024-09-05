using UnityEngine;

public class Floor : MonoBehaviour
{
    public bool check = false;
    void OnMouseDown()
    {
        Debug.Log("hey");
        check = true;
    }
}
