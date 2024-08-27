using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateCanvas : MonoBehaviour
{
    public Canvas thisCanvas;
    public Canvas mainCanvas;

    void Start()
    {
        thisCanvas = gameObject.GetComponent<Canvas>();
        thisCanvas.enabled = false;
    }

    // Update is called once per frame
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