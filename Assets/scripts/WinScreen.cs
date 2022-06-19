using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinScreen : MonoBehaviour
{

    public PauseMenu PauseMenu;
    public TextMeshProUGUI timeleftText;
    private float timeleft;
    public CountdownTimer CountdownTimer;

    public void Setup()
    {

        gameObject.SetActive(true);
        PauseMenu.Freeze();

        timeleft = CountdownTimer.startingTime - CountdownTimer.currentTime;
        timeleftText.text = "You've collected all CDs within "+timeleft.ToString(".00") + " seconds!";


    }
}
