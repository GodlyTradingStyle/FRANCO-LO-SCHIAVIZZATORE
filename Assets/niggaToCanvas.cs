using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class niggaToCanvas : MonoBehaviour
{
    public niggaStats Nigga;
    public Canvas niggaCanvas;
    public UpgradeContainer upgradeContainer;
    void Start()
    {
        niggaCanvas = GameObject.Find("NiggaCanvas").GetComponent<Canvas>();
        upgradeContainer = GameObject.Find("UpgradeContainer").GetComponent<UpgradeContainer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getNigga()
    {
        Nigga = GetComponentInParent<panelNigga>().niggaScript;
        upgradeContainer.nigga = Nigga;
        upgradeContainer.upgrades = Nigga.GetComponent<NiggaUpgrade>();
    }
}
