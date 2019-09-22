using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    Text timeNow;

    // Start is called before the first frame update
    void Start()
    {
        timeNow = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeNow.text = $"Time: {Time.time:F1}";
    }
}
