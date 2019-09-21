using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satistics : MonoBehaviour
{
    public static int killValue = 0;


    // Start is called before the first frame update
    void Start()
    {
        EventController.SubscribeToEvent(GameEvents.IncreaseScore1, increaseScore);
    }

    void increaseScore(object ob1, object ob2)
    {
        killValue++;
    }

    private void OnDisable()
    {
        EventController.UnsubscribeFromEvent(GameEvents.IncreaseScore1, increaseScore);
    }

    void Update()
    {
    }
}
