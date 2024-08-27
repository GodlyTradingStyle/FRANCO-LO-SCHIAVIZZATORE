using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class currentMoney : MonoBehaviour
{
    

    public float Money = 100;
    public TextMeshProUGUI moneyText;
    public dataStorage dataStorage;



    void Start()
    {
        dataStorage = FindAnyObjectByType<dataStorage>();
    }
    // Update is called once per frame
    void Update()
    {
        Money = dataStorage.money;
        moneyText.text = Money.ToString() + "$";
    }

   


    


}
