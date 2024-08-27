using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class currentNiggas : MonoBehaviour
{


    public int niggas = 0;
    public TextMeshProUGUI yourNiggas;


    void Start()
    {
        
    }

    void Update()
    {
        yourNiggas.text = "i tuoi negri: " + niggas.ToString();
    }


    public void addNigga()
    {
        niggas = niggas + 1;
    }
}
