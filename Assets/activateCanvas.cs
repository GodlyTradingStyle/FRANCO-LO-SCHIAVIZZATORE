using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activateCanvas : MonoBehaviour
{
    public Canvas canvasToOpen;
    public Canvas canvasToClose;
    public Canvas niggaCanvas;

    public Canvas thisCanvas;
    public bool startActive = true;
    public bool closeThis = false;
    public bool dontClose = false;
    public bool dontOpen = false;
    public bool openNigga = false ;

    void Start()
    {
        if (openNigga == true)
        {
            niggaCanvas = GameObject.Find("NiggaCanvas").GetComponent<Canvas>();
            canvasToOpen = niggaCanvas;
        }
        thisCanvas = GetComponentInParent<Canvas>();
        if (startActive==false)
        {
            thisCanvas.enabled = false;
        }
        if (closeThis == true)
        {
            canvasToClose = thisCanvas;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void turnOn()
    {
        if (dontOpen == false)
        {
            canvasToOpen.enabled = true;
        }
        if (dontClose == false)
        {
            canvasToClose.enabled = false;
        }
    }
}