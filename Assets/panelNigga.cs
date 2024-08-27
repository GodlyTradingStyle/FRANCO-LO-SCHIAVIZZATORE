using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class panelNigga : MonoBehaviour
{
    public GameObject Nigga;
    public niggaStats niggaScript;

    public TextMeshProUGUI Name;
    public TextMeshProUGUI Level;

    public GameObject panel;
    public Slider slider;

    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Nigga!=null)
        {
            Level.text = "LV" + niggaScript.level.ToString();
            slider.value = niggaScript.time/10;
        }

    }

    public void associateNigga( GameObject nigga)
    {
        Nigga = nigga;
        niggaScript = nigga.GetComponent<niggaStats>();
        Name.text = niggaScript.niggaName;
        panel.SetActive(true);
    }
}
