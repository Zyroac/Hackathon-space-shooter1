using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;
using System.Threading.Tasks;

public class Time_Counter : MonoBehaviour
{

    public Text zeittext;
    float zeit = 0;
    float anfangszeit = 0;



    // Start is called before the first frame update
    void Start()
    {
        zeit = anfangszeit;
    }

    // Update is called once per frame
    void Update()
    {
       
        zeit += 1 * Time.deltaTime;
        zeittext.text = "Time:" + zeit.ToString();
    }
}

