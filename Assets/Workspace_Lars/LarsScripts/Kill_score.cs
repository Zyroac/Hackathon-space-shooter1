using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill_score : MonoBehaviour
{
    public Transform owner;
    public static int killValue = 0;
    Text kill;



    // Start is called before the first frame update
    void Start()
    {
        kill = GetComponent<Text>();
        EventController.SubscribeToEvent(GameEvents.IncreaseScore1, increaseScore);
    }

    void increaseScore(object source, object target)
    {
            var target1 = (GameObject)target;

            if(target1!=owner)
            {
                killValue++;
            }
    }

    private void OnDisable()
    {
        EventController.UnsubscribeFromEvent(GameEvents.IncreaseScore1, increaseScore);
    }

    // Update is called once per frame
    void Update()
    {
        kill.text = "Kills:  " + killValue;
    }
}
