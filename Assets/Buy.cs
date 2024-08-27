using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    public dataStorage dataStorage;
    public Button button;

    void Start()
    {
       
    }

    void Update()
    {
        if (dataStorage.money<dataStorage.niggaCost)
        {
            button.interactable = false;

        }
        else
        {
           button.interactable = true;

        }
    }
    

}
