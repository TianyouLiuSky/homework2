using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NavMeshAgent : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform baseTransform;
    public Boolean isStopped;
    private void Awake()
    {
        baseTransform = GameObject.Find("BaseDamagePoint").transform;
        agent = GetComponentInParent<NavMeshAgent>();
    }

    internal void SetDestination(Vector3 position)
    {
        throw new NotImplementedException();
    }

    // set destination part, the book is very unclear on where the code should be put, and the setDestination function is neither a unity function nor defined
}
