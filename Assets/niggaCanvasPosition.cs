using UnityEngine;

public class SetAbsolutePosition : MonoBehaviour
{
    public RectTransform childRectTransform;

    void Start()
    {
        // Disabilita l'influenza degli anchor
        childRectTransform.anchorMin = new Vector2(0, 0);
        childRectTransform.anchorMax = new Vector2(0, 0);

        // Imposta il pivot (il punto di riferimento per la posizione)
        childRectTransform.pivot = new Vector2(0.5f, 0.5f);

        // Imposta la posizione assoluta
        Vector2 absolutePosition = new Vector2(100f, 200f); // Cambia questi valori per le coordinate che desideri
        childRectTransform.anchoredPosition = absolutePosition;
    }
}
