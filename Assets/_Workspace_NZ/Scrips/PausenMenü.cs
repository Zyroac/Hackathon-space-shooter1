using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausenMenü : MonoBehaviour
{
    public static bool SpielIstPausiert = false;
    public GameObject PausenMenüUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SpielIstPausiert)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        PausenMenüUI.SetActive(false);
        Time.timeScale = 1f;
        SpielIstPausiert = false;
    }

    void Pause ()
    {
        PausenMenüUI.SetActive(true);
        Time.timeScale = 0f;
        SpielIstPausiert = true;
    }

    public void LadeMenü()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void SpielBeenden()
    {
        Application.Quit();
    }
}
