using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int startCost = 100;

    [SerializeField] GameObject Star;
   
   public void AddStars(int amount)
    {
       // Instantiate(Star, transform.position, Quaternion.identity);
        FindObjectOfType<StarDisplay>().addStar(amount);
    }
    public int GetStarCost()
    {
        return startCost;
    }
}
