using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DefenderButton : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;


    public void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        TextMeshProUGUI text = GetComponentInChildren<TextMeshProUGUI>();
        if (!text)
        {
            Debug.LogError(name + "hasnot cost text");
        }
        else
        {
            text.text = defenderPrefab.GetStarCost().ToString();
        }
    }

    private void OnMouseDown()
    {

        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41,255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;

        if(defenderPrefab == null)
        {
            Debug.Log("nullll");
        }
        FindObjectOfType<DefenderSpawnder>().SetDefender(defenderPrefab);


       
    }
}
