using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dataStorage : MonoBehaviour
{
    public currentMoney moneyScript;
    public currentNiggas niggaScript;
    public float money;

    public TextMeshProUGUI niggaCostText;
    public float niggaCost;
    public Object Nigga;

void Start()
    {
        if (PlayerPrefs.GetFloat("currentMoney") != 1.0f)
        {
            money = PlayerPrefs.GetFloat("currentMoney");
        }
    }

    // Update is called once per frame
    void Update()
    {
        niggaCost = 10 * (niggaScript.niggas + 1);
        niggaCostText.text = niggaCost.ToString();
        SavePrefs();
        Debug.Log(money);
    }

    public void buyNigga()
    {
        Buy(niggaCost);
        niggaScript.addNigga();
        Instantiate(Nigga);
    }


    public void Cheat()
    {
        Earn(500);
    }
    public void Reset()
    {
        money=100;
    }

    public void Buy(float costo)
    {
        money = money - costo;
    }

    public void Earn(float soldi)
    {
        money = money + soldi;
    }





    public void SavePrefs()
    {
        PlayerPrefs.SetFloat("currentMoney", money);
        PlayerPrefs.Save();
    }

}
