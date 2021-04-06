using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] float waitToloard;
    int NumberofAttackers = 0;
    public bool levelTimerFinish = false;
   
    private void Start()
    {

    }

    public void AttackerSpawned()
    {
        NumberofAttackers++;
        Debug.Log("SpawnAttacker" + NumberofAttackers);
    }

    public IEnumerator Handlewincondition()
    {

        FindObjectOfType<PauseMenu>().SetwinlevelActive();
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToloard);
        FindObjectOfType<LevelLoader>().LoardNextScene();
    }
    public void AttackerKilled()
    {
        NumberofAttackers--;
        Debug.Log("number Of attackers:" + NumberofAttackers);

        if (NumberofAttackers <= 0 && levelTimerFinish /*&& GameHandler.Gm.gameOver != true*/) {
            Debug.Log("win!!!!!!!!!!");
            
            StartCoroutine(Handlewincondition());
        }
    }

    public void LeveltimerFinshed()
    {
        Debug.Log("DOn LEvel");
        levelTimerFinish = true;
        StopSpawners();

        
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnarray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnarray)
        {
            spawner.stopSpawning();
        }
    }
}
