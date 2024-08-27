using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niggaStatsCanvas : MonoBehaviour
{


    public Canvas thisCanvas;
    public Canvas mainCanvas;

    void Start()
    {
        thisCanvas = gameObject.GetComponent<Canvas>();
        thisCanvas.enabled = false;
    }

    void Update()
    {
        
    }


    public void turnOn()
    {
        thisCanvas.enabled = true;
        mainCanvas.enabled = false;
    }
    public void turnOff()
    {
        thisCanvas.enabled = false;
        mainCanvas.enabled = true;
    }
}
