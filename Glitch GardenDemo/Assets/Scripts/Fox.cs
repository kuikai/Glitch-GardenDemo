using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    public float startHealth;

    public Animator ani;
    private void Start()
    {
       // Running();
        startHealth = GetComponent<Health>().health;
    }
    public void Running()
    {
        Debug.Log("Running");
        GetComponent<Animator>().SetBool("IsRunning", true);
        ani.SetBool("IsRunning", true);
    }

    public void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherGameObejt = other.gameObject;


        if(other.gameObject.name == "GraveStone(Clone)")
        {
            Isjumping();
        }
        if (otherGameObejt.GetComponent<Defender>() &&other.gameObject.name != "GraveStone(Clone)")
        {
            Debug.Log(other.gameObject.name);
            GetComponent<Attacker>().Attack(otherGameObejt);
        }
    }
    public void Isjumping()
    {
        ani.SetBool("Isjumping", true);
    }
    public void Stopjumping()
    {
        ani.SetBool("Isjumping", false);
    }
    public void HastakingDamage()
    {
        if(startHealth < GetComponent<Health>().health)
        {
            Debug.Log("Taking damnge");
            Running();
        }

    }
}
