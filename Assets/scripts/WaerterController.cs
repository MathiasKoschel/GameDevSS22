using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaerterController : MonoBehaviour
{
    public AiSensor sensor;
    //public vThirdPersonController charakter;


    public Transform[] navPoint;
    public UnityEngine.AI.NavMeshAgent agent;
    public int destPoint = 0;
    public Transform goal;

    public float hoerweite = 7f;
    public float sichtweite = 4f;
    public Transform player;
    public float playerDistance;
    public float suchGeschw;
    public double agentSpeed = 1.75;
    public LoseScreen LoseScreen;


    public int scanFrequency = AiSensor.scanFrequency;
    float scanInterval = AiSensor.scanInterval;
    float scanTimer = AiSensor.scanTimer;

    void Awake()
    {
        GoToNextPoint();
        sensor = GetComponent<AiSensor>();
    }

    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;

        scanInterval = 1.0f / scanFrequency;
    }

    void Update()
    {
        playerDistance = Vector3.Distance(player.position, transform.position);

        /*scanTimer -= Time.deltaTime;
        if (scanTimer < 0)
        {
            scanTimer += scanInterval;*/
        if (sensor.ScanForPlayer())
        {
            LookAtPlayer();
            Verfolgen();
        //    Debug.Log("Spieler auf Sichtkontakt");
        } /*else if(playerDistance > 1f )
            {
                LookAtPlayer();
                Verfolgen();
                Debug.Log("Spieler wird verfolgt");
            } */
        else
        {
            agent.speed = (float)agentSpeed;
            if (agent.remainingDistance < 0.5f)
                GoToNextPoint();
        }
        //}






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

        
            if (playerDistance < hoerweite){
            LookAtPlayer();
            //Debug.Log("gehört");
            Verfolgen();*/





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
        if(playerDistance<= 0.5f)
        {
            LoseScreen.Setup("You got caught!");
        }
        agent.speed = 0;
        transform.Translate(Vector3.forward * suchGeschw * Time.deltaTime);
    }
}
