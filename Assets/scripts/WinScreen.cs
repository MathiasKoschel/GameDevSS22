using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{

    public PauseMenu PauseMenu;

    public void Setup()
    {

        gameObject.SetActive(true);
        PauseMenu.Freeze();


    }
}
