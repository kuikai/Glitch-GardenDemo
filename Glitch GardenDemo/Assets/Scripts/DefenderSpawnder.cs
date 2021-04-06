using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class DefenderSpawnder : MonoBehaviour
{
     Defender Defender;
    GameObject DefenderParent;

    const string DEFENDER_PARENT_NAME = "Denfenders";

    private void Start()
    {
        CreateDefenderParent();
    }

    private void CreateDefenderParent()
    {

        DefenderParent = GameObject.Find(DEFENDER_PARENT_NAME);
        if(!DefenderParent)
        {
            DefenderParent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    
    private void OnMouseDown()
    {
        Debug.Log("house was click");
        AttemptToPLaceDefender(GetSquareClick());
    }





    public void SetDefender(Defender defenderToselect)
    {
        Defender = defenderToselect;
    }
    private void SpawDefender(Vector2 Roundedpos)
    {
        Debug.Log("boohuuuu");
     //   if (Defender != null)
      //  {
            Defender newDefender = Instantiate(Defender, new Vector3(Roundedpos.x, Roundedpos.y, 0), Quaternion.identity) as Defender;
            newDefender.transform.parent = DefenderParent.transform;
    //    }
          //  Debug.Log(Roundedpos);
    }

    private Vector3 SnapetoGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newy = Mathf.FloorToInt(rawWorldPos.y);

        return new Vector2(newX, newy);

    }


    private void AttemptToPLaceDefender(Vector2 GridPos)
    {
        var startDisplay = FindObjectOfType<StarDisplay>();
        if (Defender != null)
        {
            int defenderCost = Defender.GetStarCost();

            // if er have enoght stars
            // spend the money
            // spaw defender.
            if (startDisplay.havingEniughStares(defenderCost))
            {
                SpawDefender(GridPos);

                startDisplay.SpendingStars(defenderCost);
            }
        }


    }


    private Vector2 GetSquareClick()
    {
        Vector2 ClickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
       // Debug.Log(ClickPos);
        Vector2 Worldpos = Camera.main.ScreenToWorldPoint(ClickPos);
      //  Debug.Log(Worldpos);
        Vector2 gridPos = SnapetoGrid(Worldpos);
        return gridPos;

    }

    
}
