using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaerterController : MonoBehaviour
{

    public Transform[] navPoint;
    public UnityEngine.AI.NavMeshAgent agent;
    public int destPoint = 0;
    public Transform goal;

    public float hoerweite = 7f;
    public float sichtweite = 4f;
    public Transform player;
    public float playerDistance;
    public float suchGeschw;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position; 
    }

    // Update is called once per frame
    void Update()
    {
       
        

        playerDistance = Vector3.Distance (player.position, transform.position);

/*
        if (playerDistance < hoerweite)
        {
            LookAtPlayer();
            Debug.Log("Seen");
        }

        if (playerDistance < hoerweite)
        {
            if (playerDistance > 2f)
            {
            Verfolgen();
            }
                else
            GoToNextPoint();        
        }
        
        
        if (agent.remainingDistance < 0.5f)
                GoToNextPoint();    

*/

        if(playerDistance < hoerweite){
            LookAtPlayer();
            Debug.Log("gehört");
            Verfolgen();
        }   
            
        if (playerDistance < sichtweite)
        {
        LookAtPlayer();
        Debug.Log("Spiel verloren");
        }
            else
            {
                if(agent.remainingDistance < 0.5f)
                GoToNextPoint();
            }
                    
       // if(agent.remainingDistance < 0.5f)
       //     GoToNextPoint();
    


    }

    void LookAtPlayer()
        {
            transform.LookAt(player);   
        }

    void GoToNextPoint()
        {
            if (navPoint.Length == 0)
                return;
            
            agent.destination = navPoint[destPoint].position;
            destPoint = (destPoint + 1) % navPoint.Length;
        }

    void Verfolgen()
        {
            transform.Translate (Vector3.forward * suchGeschw * Time.deltaTime);
        }
}
