using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : MonoBehaviour
{

    public static PlayerInstance instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    

}
