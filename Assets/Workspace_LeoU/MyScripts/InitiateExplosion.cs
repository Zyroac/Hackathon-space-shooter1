using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateExplosion : MonoBehaviour
{
    public Transform explosion;
    
    void Start()
    {
        Destroy(this.gameObject);
        EventController.SubscribeToEvent(GameEvents.InitExplosion, onExplosion);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDisable()
    {
        EventController.UnsubscribeFromEvent(GameEvents.InitExplosion, onExplosion);
    }

    private void onExplosion(object source, object coords)
    {
        var coordinates = (Vector3)coords;

        Instantiate(explosion, coordinates, Quaternion.identity);
    }

}
