using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class niggaStats : MonoBehaviour
{
    public float time;
    public string niggaName;
    public float initialCost = 10f;
    public float actualCost;
    public float revenue = 1f;
    public float revenueSpeed=10;
    public int level = 1;
    public float costFactor = 1.07f; // Aumenta il costo quando il personaggio viene migliorato
    public NiggaUpgrade upgrade; 
    public dataStorage dataStorage;
    public GameObject panel;
    public currentMoney Money;
    public currentNiggas Niggas;

    void Start()
    {
        dataStorage = FindAnyObjectByType<dataStorage>();
        Money = FindAnyObjectByType<currentMoney>();
        Niggas = FindAnyObjectByType<currentNiggas>();
        panel = GameObject.Find("NiggaPanel " + (Niggas.niggas - 1).ToString());
        actualCost = initialCost;
        niggaName = Niggas.niggas.ToString();
        panel.GetComponent<panelNigga>().associateNigga(gameObject);
    }



    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= revenueSpeed)
        {
            GeneraSoldi();
        }

    }






   

    public void GeneraSoldi()
    {
        dataStorage.Earn(revenue);
        time = 0;
    }


   public void applyUpgrade(NiggaUpgrade.Upgrade upgrade)
    {
        if (upgrade.upgradeName == "Revenue")
        {
            revenue = upgrade.value;
        }
        else if (upgrade.upgradeName == "Speed")
        {
            revenueSpeed /= upgrade.value;
        }
        else
        {

        }
    }


}
