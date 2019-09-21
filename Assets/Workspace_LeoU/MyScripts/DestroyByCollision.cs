using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByCollision : MonoBehaviour
{

    public float respawnTime = 2.0f;
    private float respawn;
    private Vector3 startPosition;
    private Quaternion startRotation;

    void OnTriggerEnter(Collider col)
    {
        EventController.InvokeEvent(GameEvents.JetCollides, this.gameObject, col.gameObject);

    }

    void OnTriggerExit(Collider col)
    {
        EventController.InvokeEvent(GameEvents.BoundryCollision, this.gameObject, col.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
