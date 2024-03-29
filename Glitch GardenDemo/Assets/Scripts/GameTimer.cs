﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip ("leveltime i sekundes")]
    [SerializeField] float levelTime = 10;
    bool triggeredLevelFinished = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {

            FindObjectOfType<LevelController>().LeveltimerFinshed();
            triggeredLevelFinished = true;
        }
    }
}
