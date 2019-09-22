using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPause : MonoBehaviour
{
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Pause"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(3);
        }
    }

    
}
