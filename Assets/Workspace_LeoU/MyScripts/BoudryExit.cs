using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoudryExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventController.SubscribeToEvent(GameEvents.BoundryCollision, onBoundryCollision);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnDisable()
    {
        EventController.UnsubscribeFromEvent(GameEvents.BoundryCollision, onBoundryCollision);
    }


    public void onBoundryCollision(object source, object target)
    {
            var sourceObject = (GameObject)source;
            var targetObject = (GameObject)target;

        if (targetObject.tag == "Boundry")
        {

            Vector3 posit = sourceObject.transform.position;

            if (posit.x > ((targetObject.transform.localScale.x-2)/2) ||
                posit.x < (-((targetObject.transform.localScale.x-2)/2)))
            {
                posit.x = posit.x * (-0.97f);
            }
            if (posit.z > ((targetObject.transform.localScale.z-2)/2) || 
                posit.z < (-((targetObject.transform.localScale.z-2)/2)))
            {
                posit.z = posit.z * (-0.9f);
            }

            sourceObject.transform.position = posit;
        }
    }
}
