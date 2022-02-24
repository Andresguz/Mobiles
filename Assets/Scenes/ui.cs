using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ui : MonoBehaviour
{
    public GameObject PAUSE;
    public GameObject BUT1;
    public GameObject BUT2;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BUT1.SetActive(false);
            BUT2.SetActive(false);
            PAUSE.SetActive(true);
        }
     
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void restartgame()
    {
        BUT1.SetActive(true);
        BUT2.SetActive(true);
        PAUSE.SetActive(false);
    }
    public void pause()
    {
        BUT1.SetActive(false);
        BUT2.SetActive(false);
        PAUSE.SetActive(true);
    }
    public void EXIT()
    {
        SceneManager.LoadScene(0);
    }
    public void GAMEOVER()
    {
        SceneManager.LoadScene(2);
    }
}
