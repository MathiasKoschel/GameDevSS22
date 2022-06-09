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
        if (NumberOfGames >= maxGames)
        {
            WinScreen.Setup();
        }
    }
}
