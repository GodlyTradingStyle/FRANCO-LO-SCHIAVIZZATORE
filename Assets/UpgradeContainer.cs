using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeContainer : MonoBehaviour
{
    public TMP_Text description;
    public TMP_Text level;
    public niggaStats nigga;
    public NiggaUpgrade upgrades;
    public NiggaUpgrade.Upgrade currentUpgrade;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SearchForNiggas()
    {
        nigga = GetComponentInParent<niggaStats>();
        upgrades = nigga.GetComponent<NiggaUpgrade>();
    } 
    public void ShowUpgrade(string upgrade)
    {
        currentUpgrade = upgrades.upgrades.Find(u => u.upgradeName == upgrade);
        description.text = currentUpgrade.description;
        level.text = currentUpgrade.level.ToString();
    }
    public void Upgrade()
    {
        upgrades.ApplyUpgrade(currentUpgrade.upgradeName);
    }


}
