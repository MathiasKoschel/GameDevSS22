using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    public Transform player;
    public float playerDistance;
    public float maxOpend;
    public float maxClosed;
    public Transform doorObj;
    public float doorspeed = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);
        
        if (playerDistance < 7f)
        {
            if (doorObj.transform.position.y <= maxOpend)
            {
                doorObj.transform.Translate(0f, doorspeed * Time.deltaTime ,0f);
            }

        }
        else
        {
            if (doorObj.transform.position.y >= maxClosed)
            {
                doorObj.transform.Translate(0f, -doorspeed * Time.deltaTime, 0f);
            }
        }
    }
}
