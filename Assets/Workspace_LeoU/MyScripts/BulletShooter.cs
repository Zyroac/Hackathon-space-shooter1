using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{   
    public Transform bullet;
    public Transform spawner;
    private float lastShot;
    public float shotDelay=0.1f;
    public int playerNum=1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Shoot"+playerNum) && lastShot<(Time.time-shotDelay))
        {

            var bullet1 = Instantiate(bullet, spawner.position, spawner.rotation);
            bullet1.GetComponent<BulletMover>().super=transform;
            //bullet1.time

            lastShot=Time.time;
        }
    }
}
