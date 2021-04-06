using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Attacker : MonoBehaviour
{

    [Range(0f, 5f)]
    [SerializeField] float CurrentSpeed = 1f;

    GameObject currentTarget;
    Animator ani;

    LevelController levelController;

    public void Awake()
    {
      //  FindObjectOfType<LevelController>().AttackerSpawned();
    }
    private void OnDestroy()
    {

        levelController = FindObjectOfType<LevelController>();
        if(levelController!= null)
        {
            levelController.AttackerKilled();
        }
    }
    public void Start()
    {
        
    }


    void Update()
    {
        UpdateAnimationState();
        transform.Translate(Vector2.left* CurrentSpeed * Time.deltaTime);
    }
    public void SetMoveMentSpeed(float speed)
    {
        CurrentSpeed = speed;
    }
    
    public void Attack(GameObject target)
    {
        ani = GetComponent<Animator>();
        ani.SetBool("IsAttacking", true);
        currentTarget = target;

    }

    public void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("IsAttacking", false);
        }
    }
    public void StrickCurrentTarget(float Damnge)
    {
        

        if (!currentTarget) { return; }

        Health health = currentTarget.GetComponent<Health>();
      //  Debug.Log("asda" +currentTarget.name);
        if (health)
        {
            health.DealDamng(Damnge);
        }
    }
   
    
}
