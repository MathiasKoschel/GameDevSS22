using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public GameObject camMain;
    public GameObject cam1;
    public GameObject cam2;

    public bool securityactive = false;
    public bool cam1active = false;

    public Transform console;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Vector3.Distance(console.position, transform.position)<=2f && Input.GetKeyDown(KeyCode.E) && securityactive == false)
        {
            Debug.Log("security an");
            securityactive = true;
            cam1active = true;
            camMain.SetActive(false);
            cam1.SetActive(true);
            cam2.SetActive(false);

        }
       else if (securityactive == true)
        {
            if(Vector3.Distance(console.position, transform.position) >= 2f || Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("security aus");
                securityactive = false;
                cam1active = false;
                camMain.SetActive(true);
                cam1.SetActive(false);
                cam2.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (cam1active == true)
                {
                    cam1.SetActive(false);
                    cam2.SetActive(true);
                    cam1active = false;
                } else
                {
                    cam1.SetActive(true);
                    cam2.SetActive(false);
                    cam1active = true;
                }
            }
        }   
        
    }
}
