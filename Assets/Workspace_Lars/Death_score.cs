using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Death_score : MonoBehaviour
{
  


    public static int deathValue = 0;
    Text death;



    // Start is called before the first frame update
    void Start()
    {
        death = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        death.text = "Deaths:" + deathValue;
    }
}
