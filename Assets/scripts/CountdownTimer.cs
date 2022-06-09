using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;
    [SerializeField] Text CountdownText;
    public LoseScreen LoseScreen;
    public WinScreen WinScreen;
    

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!LoseScreen.gameObject.activeSelf && !WinScreen.gameObject.activeSelf)
        {
            if (currentTime <= 0)
            {
                //losecondition
                LoseScreen.Setup("Out of time!");
            }
            else
            {
                currentTime -= 1 * Time.deltaTime;
                CountdownText.text = "Time left: " + currentTime.ToString("0");
            }
        }
        
        
    }
}
