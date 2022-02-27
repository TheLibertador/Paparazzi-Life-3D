using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamButtonController : MonoBehaviour
{
    public RotateCamera rotateCamera;
    public ScrollAndPinch scrollAndPinch;


    private bool boolean = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    public void OnButtonPressed()
    {
        if (boolean)
        {
            boolean = false;
            scrollAndPinch.enabled = true;
            rotateCamera.enabled = false;
            
        }
        else if (boolean)
        {
            boolean = true;
            scrollAndPinch.enabled = false;
            rotateCamera.enabled = true;
        }
    }

   
}
