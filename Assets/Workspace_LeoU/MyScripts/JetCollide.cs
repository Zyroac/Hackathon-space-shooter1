using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventController.SubscribeToEvent(GameEvents.JetCollides, onCollision);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDisable()
    {
        EventController.UnsubscribeFromEvent(GameEvents.JetCollides, onCollision);
    }

    private void onCollision(object source, object target)
    {
        var sourceObject = (GameObject)source;
        var targetObject = (GameObject)target;

        if (targetObject.tag == "Jet")
        {
            sourceObject.SetActive(false);
            EventController.InvokeEvent(GameEvents.SpawnJets, this, sourceObject);
            EventController.InvokeEvent(GameEvents.InitExplosion, this, sourceObject.transform.position);
        }
        else if (targetObject.tag == "Bullet" &&
                targetObject.GetComponent<BulletMover>().super.gameObject != sourceObject)
        {
            sourceObject.SetActive(false);
            Destroy(targetObject);

            EventController.InvokeEvent(GameEvents.SpawnJets, this, sourceObject);
            EventController.InvokeEvent(GameEvents.IncreaseScore, this, sourceObject);
            EventController.InvokeEvent(GameEvents.InitExplosion, this, sourceObject.transform.position);
        }
        
    }
}
