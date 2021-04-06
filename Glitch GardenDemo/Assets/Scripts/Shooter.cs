using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile, gun;


    GameObject ProjectilesParent;

    const string PROJECTILE_PARENT_NAME = "Projectiles";

    AttackerSpawner myLandSpawner;
    Animator ani;

    public void Start()
    {
        CreateProjectileParent();
        ani = GetComponent<Animator>();

        SetLaneSpawner();
    }

    private void CreateProjectileParent()
    {
        ProjectilesParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!ProjectilesParent)
        {
            ProjectilesParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            ani.SetBool("IsAttacking", true);
       //     Debug.Log("pew pew pew");
        }
        else
        {
            ani.SetBool("IsAttacking", false);
          //  Debug.Log("sit and wait");
        }
    }

    private void SetLaneSpawner()
    {
        
        AttackerSpawner[] spawner = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawn in spawner)
        {
            bool IsCloseEnough = (Mathf.Abs(spawn.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            Debug.Log(Mathf.Abs(spawn.transform.position.y - transform.position.y));
            Debug.Log(Mathf.Epsilon);
            Debug.Log("yepyep "+ IsCloseEnough );
            if(IsCloseEnough)
            {
                myLandSpawner = spawn;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLandSpawner != null)
        {
            if (myLandSpawner.transform.childCount <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
         //   Debug.Log("No Spaweer");
            return false;
        }
        // if my land spawner child count less than or equal to 0 
        // return false;
    }
    public void Fire()
    {
       GameObject projectil = Instantiate(projectile, gun.transform.position, Quaternion.identity) as GameObject;
       projectil.transform.parent = ProjectilesParent.transform;


    }
}
