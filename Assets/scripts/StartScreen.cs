using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startLevel1()
    {
        Debug.Log("level1");
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void startLevel2()
    {
        Debug.Log("level2");
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void settings()
    {

    }

    public void quitGame()
    {
        Application.Quit();
    }
}
