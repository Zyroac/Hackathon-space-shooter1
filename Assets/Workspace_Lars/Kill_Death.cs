﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;
using System.Threading.Tasks;

public class Kill_Death : MonoBehaviour
{
    float kd = 0;
   public Text killrate;
    // Start is called before the first frame update
    void Start()
    {
        killrate.text = kd;
    }

    // Update is called once per frame
    void Update()
    {
      kd= Kill_score.killValue / Death_score.deathValue;

        killrate.text = "KD:" + kd.ToString();
    }
}
