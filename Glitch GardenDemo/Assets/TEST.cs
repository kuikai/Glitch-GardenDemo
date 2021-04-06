using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefController.SetMasterVolume(0.3f);

        Debug.Log("lol taber the volume is" + PlayerPrefController.GetMasterVoulme());
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
