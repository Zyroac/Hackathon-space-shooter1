using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalMessage : MonoBehaviour
{
    public static FinalMessage instance;
    Text message;


    public void Awake()
    {
       instance=this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<Text>();
        message.text="";
    }

    public void SendMessage(int pCase)
    {
        switch (pCase)
        {
            case 0:
                message.text = "DRAW!!!";
                break;
            case 1:
                message.text = "PLAYER 1 WINS!!!";
                break;
            case 2:
                message.text = "PLAYER 2 WINS!!!";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
