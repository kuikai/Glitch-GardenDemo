using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameHandler : MonoBehaviour
{
    [SerializeField] int PlayerLife = 3;
    public static GameHandler Gm;
    public bool gameOver = false;
    public float  PlayerCurrentlife;


    public GameObject[] lifes;
    public void Awake()
    {

        if (Gm == null)
        {
            DontDestroyOnLoad(gameObject);
            Gm = this;
        }
        else if (Gm != this)
        {
            Destroy(gameObject);
        }
     
    }
    public void Start()
    {

        PlayerCurrentlife = PlayerLife - (int)PlayerPrefController.GetDifferculty();

        if (PlayerCurrentlife == 2)
        {
           FindObjectOfType<DestoyIfHit>().lifes[2].SetActive(false);
        }
        if (PlayerCurrentlife == 1)
        {
            FindObjectOfType<DestoyIfHit>().lifes[2].SetActive(false);
            FindObjectOfType<DestoyIfHit>().lifes[1].SetActive(false);
        }
        if (PlayerCurrentlife == 0)
        {

        }
        Debug.Log(PlayerPrefController.GetDifferculty());
        
    }
    public int GerPlayerLife()
    {
        return PlayerLife;
    }


    
    public void SetLifeStars()
    {
        PlayerCurrentlife = PlayerLife - (int)PlayerPrefController.GetDifferculty();

        if (PlayerCurrentlife == 2)
        {
            FindObjectOfType<DestoyIfHit>().lifes[2].SetActive(false);
        }
        if (PlayerCurrentlife == 1)
        {
            FindObjectOfType<DestoyIfHit>().lifes[2].SetActive(false);
            FindObjectOfType<DestoyIfHit>().lifes[1].SetActive(false);
        }
    }
    public void Reset()
    {
        PlayerCurrentlife = PlayerLife - (int)PlayerPrefController.GetDifferculty();

        if (PlayerCurrentlife == 2)
        {
            FindObjectOfType<DestoyIfHit>().lifes[2].SetActive(false);
        }
        if (PlayerCurrentlife == 1)
        {
            FindObjectOfType<DestoyIfHit>().lifes[2].SetActive(false);
            FindObjectOfType<DestoyIfHit>().lifes[1].SetActive(false);
        }
    }
    public void GameOver()
    {
        
        gameOver = true;
        FindObjectOfType<PauseMenu>().SetGameOverActive();
  
    }
    public void LoseLife()
    {
        PlayerCurrentlife--;
        if(PlayerCurrentlife <= 0)
        {
            GameOver();
        }
    }
}
