using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class DestoyIfHit : MonoBehaviour
{

    public int life = 0;
    private float AmoutOflives;
    
    public GameObject[] lifes;
    public void Start()
    {
        AmoutOflives = FindObjectOfType<GameHandler>().GerPlayerLife();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log((int)GameHandler.Gm.PlayerCurrentlife - 1);

        if(GameHandler.Gm.PlayerCurrentlife - 1 >=0 && GameHandler.Gm.PlayerCurrentlife <= 3)
        {
            lifes[(int)GameHandler.Gm.PlayerCurrentlife - 1].SetActive(false);
        }

        FindObjectOfType<GameHandler>().LoseLife();


        
        
        Destroy(collision.gameObject);
    

    }

}
