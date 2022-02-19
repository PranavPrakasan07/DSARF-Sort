using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    public GameObject Up;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpClick()
    {
        Debug.Log("Up clicked");
    }

    public void DownClick()
    {
        Debug.Log("Down clicked");
    }

    public void LeftClick()
    {
        Debug.Log("Left clicked");
    }

    public void RightClick()
    {
        Debug.Log("Right clicked");
    }
}
