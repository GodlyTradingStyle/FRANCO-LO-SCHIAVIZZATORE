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






    public void Upgrade()
    {
        level++;
        revenue *= 1.05f; // Aumenta la produzione di soldi per secondo
        actualCost *= costFactor; // Aumenta il costo per il prossimo livello
    }

    public void GeneraSoldi()
    {
        dataStorage.Earn(revenue);
        time = 0;
    }

}
