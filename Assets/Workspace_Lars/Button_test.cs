﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_test : MonoBehaviour
{
    // Start is called before the first frame update
   public void killhoch()
    {
       // if (bool = true) { 
        Kill_score.killValue += 1;

        Death_score.deathValue += 1;

        // }
    }

}
