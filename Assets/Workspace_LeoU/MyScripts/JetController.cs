using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetController : MonoBehaviour
{
    public float velSpeed = 1000;
    public float rotSpeed = 250;
    public int playerNum=1;

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"+playerNum);
        float moveVertical = Input.GetAxis("Vertical"+playerNum);

        var body = GetComponent<Rigidbody>();
        Vector3 rotation = new Vector3(0.0f, moveHorizontal * rotSpeed * Time.deltaTime, 0.0f);
        transform.Rotate(rotation);

        body.velocity = transform.forward * moveVertical * velSpeed * Time.deltaTime;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

    }
}
