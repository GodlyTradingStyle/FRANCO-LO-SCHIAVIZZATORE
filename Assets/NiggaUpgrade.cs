using UnityEngine;
using System.Collections.Generic;

public class NiggaUpgrade : MonoBehaviour
{


    public niggaStats nigga;


    // Classe dedicata agli upgrade
    [System.Serializable]
    public class Upgrade
    {
        public string upgradeName;  // Nome dell'upgrade
        public string description;  // Descrizione dell'upgrade
        public int level;           // Livello attuale dell'upgrade
        public int maxLevel;        // Livello massimo dell'upgrade
        public float value;         // Valore dell'upgrade (può essere usato per aumentare una statistica)

        
        // Metodo per applicare l'upgrade
        public void ApplyUpgrade()
        {
            if (level < maxLevel)
            {
                level++;
                // Logica per aumentare il valore o effetto dell'upgrade
                value *= 1.1f; // Esempio: aumenta il valore del 10% per ogni livello
            }
        }

        // Metodo per ottenere una descrizione dell'upgrade
        public string GetUpgradeInfo()
        {
            return $"{upgradeName} (Livello {level}/{maxLevel}): {description}. Valore attuale: {value}";
        }
    }

    // Lista di upgrade posseduti dal giocatore
    public List<Upgrade> upgrades;

    void Start()
    {
        // Inizializza gli upgrade (esempio)
        upgrades = new List<Upgrade>()
        {
            new Upgrade { upgradeName = "Revenue", description = "Aumenta il guadagno del negro", level = 1, maxLevel = 1000000, value = 10f },
            new Upgrade { upgradeName = "Speed", description = "Aumenta la velocità di guadagno del negro", level = 1, maxLevel = 20, value = 1f }
        };
    }

    // Metodo per applicare un upgrade specifico
    public void ApplyUpgrade(string upgradeName)
    {
        Upgrade upgrade = upgrades.Find(u => u.upgradeName == upgradeName);
        if (upgrade != null)
        {
            upgrade.ApplyUpgrade();
            nigga.applyUpgrade(upgrade);
            Debug.Log($"Upgrade applicato: {upgrade.GetUpgradeInfo()}");
        }
        else
        {
            Debug.LogWarning($"Upgrade '{upgradeName}' non trovato.");
        }
    }

    // Metodo di esempio per utilizzare un upgrade
    void Update()
    {
    }
}
