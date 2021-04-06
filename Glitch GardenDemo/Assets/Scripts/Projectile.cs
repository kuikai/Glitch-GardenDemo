using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{


    [SerializeField] float speed = 4;
    [SerializeField] float rotetionSpeed;
    [SerializeField] float damage = 100;
    // Update is called once per frame
    void Update()
    {
       // transform.Translate(new Vector2(0,1) * speed * Time.deltaTime);
        transform.position = transform.position + new Vector3(1, 0,0) * speed * Time.deltaTime;
        transform.transform.Rotate(0, 0, rotetionSpeed,Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

     //   Debug.Log("lalal");
        if (collision.GetComponent<Fox>())
        {
            collision.GetComponent<Fox>().Running();
        }
        
        var health = collision.GetComponent<Health>();
        var attaker = collision.GetComponent<Attacker>();
        
        
        if(health && attaker) {
            health.DealDamng(damage);
            Destroy(gameObject);
        }
        
  
    }
}
