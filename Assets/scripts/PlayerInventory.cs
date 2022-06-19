using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour


{
    public int NumberOfGames { get; private set; }
    public int maxGames =1;
    public static PlayerInventory instance;
    public WinScreen WinScreen;
    public bool gewonnen = false;
    public Transform player;
    public Transform exitPoint;

    public void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }


    public UnityEvent<PlayerInventory> OnGameCollected;

    public void GameCollected()
    {
        NumberOfGames++;
        OnGameCollected.Invoke(this);
    }

    void Update()
    {
      //  Debug.Log(Vector3.Distance(player.position, exitPoint.position));

        if (NumberOfGames >= maxGames && gewonnen == false)
        {
            if(Vector3.Distance(player.position, exitPoint.position) <= 2f)
            {
                gewonnen = true;
                WinScreen.Setup();
            }
            
        }
    }
}
