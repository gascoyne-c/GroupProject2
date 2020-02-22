using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//IGNORE THIS ENTIRE SCRIPT. It should be left unchecked in the Unity Inspector.

public class Enemy : MonoBehaviour
{
    [SerializeField]

    Transform destination;
    NavMeshAgent navMeshAgent;

    public float speed;

    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();

        if(navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to " + gameObject.name);
        }

        else
        {
            SetDestination();
        }

    }

    private void SetDestination()
    {
        if(destination != null)
        {
            Vector3 targetVector = destination.transform.position;
            navMeshAgent.SetDestination(targetVector);
        }
    }

    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, destination.position, speed * Time.deltaTime);
    }
}