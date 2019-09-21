using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJet : MonoBehaviour
{
    public Transform jet;
    private Vector3 startPosition;
    private Quaternion startRotation;
    public float respawnTime = 5.0f;
    private float respawn;
    // Start is called before the first frame update
    void Start()
    {
        EventController.SubscribeToEvent(GameEvents.SpawnJets, onSpawn);

        startPosition = jet.position;
        startRotation = jet.rotation;


    }

    // Update is called once per frame
    void Update()
    {
        if (!jet.gameObject.activeSelf && respawn < Time.time)
        {

            jet.transform.SetPositionAndRotation(startPosition, startRotation);

            jet.gameObject.SetActive(true);

        }
    }

    private void OnDisable()
    {
        EventController.UnsubscribeFromEvent(GameEvents.SpawnJets, onSpawn);
    }

    private void onSpawn(object source, object args)
    {
        var sourceJet = (GameObject)args;
        if (jet.gameObject != sourceJet) return;

        respawn = Time.time + respawnTime;
    }
}
