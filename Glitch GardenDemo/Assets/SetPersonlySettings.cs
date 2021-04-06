using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetPersonlySettings : MonoBehaviour
{

    [SerializeField] AudioMixer MainAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        PersonlyAudioSettings();
    }

    public void PersonlyAudioSettings()
    {
        MainAudio.SetFloat("Volume", PlayerPrefController.GetMasterVoulme());

    }
  
}
