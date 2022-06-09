using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScreen : MonoBehaviour
{

    public Text pointstext;
    public Text conditiontext;
    public PauseMenu PauseMenu;
    
    public void Setup(string grund)
    {

        gameObject.SetActive(true);
        conditiontext.text = grund;
        pointstext.text = "Games collected: " + PlayerInventory.instance.NumberOfGames.ToString() + "/" + PlayerInventory.instance.maxGames.ToString();

        PauseMenu.Freeze();
    }



}
