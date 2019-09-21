using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using nvp.Events;
using System;

public class GameDummy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NvpEventController.SubscribeEvent("GamePaused", OnGamePaused);
        NvpEventController.SubscribeEvent("GameResumed", OnGameResumed);
    }

    private void OnGameResumed(object arg1, object arg2)
    {
        Console.WriteLine("Resumed");
        
    }

    private void OnGamePaused(object arg1, object arg2)
    {
        Console.WriteLine("Paused");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
