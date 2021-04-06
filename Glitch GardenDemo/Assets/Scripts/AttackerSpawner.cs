using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] bool spawner = true;
    [SerializeField] Attacker[] Attakerprefab;

    private IEnumerator spawnerAttackers;
   

    // Update is called once per frame
 
     IEnumerator Start()
    {
        while (spawner)
        {

            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            if (spawner == true)
            {
                SpawnAttker();
            }

        }

    }

    public void stopSpawning()
    {
        spawner = false;
    }

    private void SpawnAttker()
    {
        FindObjectOfType<LevelController>().AttackerSpawned();
        //   Debug.Log(Random.Range(0, 3));
        
        Attacker newAttacker = Instantiate(Attakerprefab[Random.Range(0,Attakerprefab.Length)], transform.position, Quaternion.identity) as Attacker; 
        newAttacker.transform.parent = transform;
    }



    void Update()
    {
       
    }

}
