using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefController : MonoBehaviour
{

    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFIVULTY_KEY = "differculty";

    
    const float MIN_VOLUME = -80f;
    const float MAX_VOLUME = 20f;


    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 2f;
    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            Debug.Log("maset colume set to" + volume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master Volume is out of range");
        }
    }

    public static float GetMasterVoulme()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }


    public static void SetDifficulty(float differculty)
    {

        if( differculty >=MIN_DIFFICULTY && differculty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFIVULTY_KEY, differculty);
        }
        else
        {
            Debug.LogError("Diffculty Out of range");
        }
    }


    public static float GetDifferculty()
    {
        return PlayerPrefs.GetFloat(DIFFIVULTY_KEY);
    }
}
