﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill_score : MonoBehaviour
{


    public static int killValue = 0;
    Text kill;



    // Start is called before the first frame update
    void Start()
    {
        kill = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        kill.text = "Kills:" + killValue;
    }
}
