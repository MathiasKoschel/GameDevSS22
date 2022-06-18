using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public GameObject source;
    public GameObject settings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void settingsactivate()
    {
        source.SetActive(false);
        settings.SetActive(true);
    }

    public void settingsdeactivate()
    {
        source.SetActive(true);
        settings.SetActive(false);
    }
}
