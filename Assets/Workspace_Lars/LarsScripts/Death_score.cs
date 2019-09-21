using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Death_score : MonoBehaviour
{
  


    public int deathValue = 0;
    Text death;



    // Start is called before the first frame update
    void Start()
    {
        death = GetComponent<Text>();
    }

    void increaseScore(object o, object b)
    {
        deathValue++;
    }



    // Update is called once per frame
    void Update()
    {

        death.text = "Deaths:" + deathValue;
    }
}
