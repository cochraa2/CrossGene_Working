using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    private NavMeshAgent agent = null;
    [SerializeField] private Transform target;
    private Animator anim = null;

    private void Start()
    {
        GetReferences();
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        agent.SetDestination(target.position);
        anim.SetFloat("Speed", 1f, 0.3f, Time.deltaTime);
        RotateToTarget();

        float distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= agent.stoppingDistance)
        {
            anim.SetFloat("Speed", 0f);
        }
        
    }

    private void RotateToTarget()
    {
        Vector3 direction = target.position - transform.position;
        direction.y = 0;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = rotation;
    }

    private void GetReferences()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
    }
}
