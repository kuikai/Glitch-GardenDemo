using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MusikPlayerscript : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource audioSource;
    void Start()
    {
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
      //  audioSource.volume = PlayerPrefController.GetMasterVoulme();
    }

    public void SetVoume(float Volume)
    {
        audioSource.volume = Volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
