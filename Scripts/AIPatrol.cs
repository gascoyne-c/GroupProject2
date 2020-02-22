using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPatrol : MonoBehaviour
{
    [SerializeField]
    bool patrolWaiting;

    [SerializeField]
    float totalWaitTime;

    [SerializeField]
    float switchProbability = 0.2f;

    [SerializeField]
    List<PatrolPoints> patrolPoints;

    //[SerializeField]
    //EnemyStates currentState;

    NavMeshAgent navMeshAgent;
    int currentPatrolIndex;
    bool travelling;
    bool waiting;
    bool patrolForward;
    float waitTimer;

    //public Transform target;
    //public Transform myTransform;

    public float speed;


    //Final attempt for the day at working out AI States for the day.
    /*
    private enum State
    {
        Patrol,
        ChasePlayer,
    }

    private State state;

    private void Awake()
    {
        state = State.Patrol;
    }
    */


    //Debug, largely ignore this.
    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (navMeshAgent == null)
        {
            Debug.LogError("The NavMeshAgent component is not attached to " + gameObject.name);
        }
        else
        {
            if (patrolPoints != null && patrolPoints.Count >= 2)
            {
                currentPatrolIndex = 0;
                SetDestination();
            }
            else
            {
                Debug.Log("Insufficient patrol points for basic patrolling behavior.");
            }
        }
    }

    public void Update()
    {
        /*switch (state)
        {
            default:
            case State.Patrol:

                break;
        }
        */

        if (travelling && navMeshAgent.remainingDistance <= 1.0f)
        {
            travelling = false;

            if (patrolWaiting)
            {
                waiting = true;
                waitTimer = 0f;
            }
            else
            {
                ChangePatrolPoint();
                SetDestination();
            }

            if (waiting)
            {
                waitTimer += Time.deltaTime;

                if (waitTimer >= totalWaitTime)
                {
                    waiting = false;

                    ChangePatrolPoint();
                    SetDestination();
                }
            }
        }
    }

    /*
    private void FindTarget()
    {
        float targetRange = 10f;
        if (Vector3.Distance(transform.position, PlayerController.Instance.GetPosition()) < targetRange) { 
}
    }
    */


    void SetDestination()
        {
        if (patrolPoints != null)
            {
                Vector3 targetVector = patrolPoints[currentPatrolIndex].transform.position;
                navMeshAgent.SetDestination(targetVector);
                travelling = true;
            }
        }

    void ChangePatrolPoint()
        {
        if (UnityEngine.Random.Range(0f, 1f) <= switchProbability)
            {
                patrolForward = !patrolForward;
            }

        if (patrolForward)
            {
                currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Count;
            }
        else
            {
            if (--currentPatrolIndex < 0)
            {
                currentPatrolIndex = patrolPoints.Count - 1;
            }
        }
    }
}