using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public Transform super;
    public float speed=15;
    public float lifeTime=10.0f;

    // Start is called before the first frame update
    void Start()
    {       
        var body = GetComponent<Rigidbody>();
        var superBody=super.GetComponent<Rigidbody>();
        body.velocity=transform.forward*speed + superBody.velocity;
        
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
    }

}
