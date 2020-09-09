using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class BubbleGaze : MonoBehaviour
{
    bool inside = false;
    // Start is called before the first frame update
    void Start()
    {
       var renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void GazeEnter()
    {
        GetComponent<Renderer>().material.color = Color.blue;
        inside = true;
    }
    
    public void GazeExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
        inside = false;
    }
        
}
