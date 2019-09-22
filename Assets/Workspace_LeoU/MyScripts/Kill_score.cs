using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kill_score : MonoBehaviour
{
    public Transform owner;
    public int killValue = 0;
    Text kill;
    int playerNumber;



    // Start is called before the first frame update
    void Start()
    {
        kill = GetComponent<Text>();
        playerNumber = owner.GetComponent<BulletShooter>().playerNum;
        EventController.SubscribeToEvent(GameEvents.IncreaseScore, increaseScore);
    }

    void increaseScore(object collide, object source)
    {
        var sourceObject = (GameObject)source;

        if (sourceObject != owner.gameObject)
        {
            killValue++;
        }
    }

    private void OnDisable()
    {
        EventController.UnsubscribeFromEvent(GameEvents.IncreaseScore, increaseScore);
    }

    // Update is called once per frame
    void Update()
    {
        //kill.text = "Player "+playerNumber+":  " + killValue;
        kill.text = $"Player {playerNumber}:  {killValue}";
    }
}
