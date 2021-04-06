using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;

    TextMeshProUGUI text;
   
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();

        text.text = "lalal";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        text.text = stars.ToString();
    }

    public void addStar(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public bool havingEniughStares(int amount)
    {
        return stars >= amount;
    }
    public void SpendingStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        else
        {
            stars = 0;
        }
    }
}
