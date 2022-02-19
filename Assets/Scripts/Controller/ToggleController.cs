using UnityEngine;

public class ToggleController : MonoBehaviour
{
    public GameObject Controller;

    /*
    private void OnMouseEnter()
    {
        Debug.Log("Hovered");
        Controller.SetActive(true);
    }
    private void OnMouseExit()
    {
        Debug.Log("Left Hovered");
        Controller.SetActive(false);
    }
    */

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }
}
