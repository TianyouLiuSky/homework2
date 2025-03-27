using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public enum EnemyState {GoToBase, AttackBase, ChasePlayer, AttackPlayer}
    public EnemyState currentState;
    public Sight sightSensor;

    public Transform baseTransform;
    public float baseAttackDistance;

    public float playerAttackDistance;
    private NavMeshAgent agent;
    public float lastShootTime;
    public GameObject bulletPrefab;
    public float fireRate;

    public Boolean isStopped;
    public ParticleSystem  muzzleEffect;

    void Update()
    {
        if (currentState == EnemyState.GoToBase) { GoToBase(); }
        else if (currentState == EnemyState.AttackBase) { AttackBase(); }
        else if (currentState == EnemyState.ChasePlayer) { ChasePlayer(); }
        else { AttackPlayer(); }
    }
    

    void GoToBase()
    {
        if (sightSensor.detectedObject != null)
        {
            currentState = EnemyState.ChasePlayer;
        }

        float distanceToBase = Vector3.Distance(
            transform.position, baseTransform.position);

        if (distanceToBase < baseAttackDistance)
        {
            currentState = EnemyState.AttackBase;
        }
    }

    void ChasePlayer()
    {
        if (sightSensor.detectedObject == null)
        {
            currentState = EnemyState.GoToBase;
            return;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, 
            sightSensor.detectedObject.transform.position);

        if (distanceToPlayer > playerAttackDistance * 1.1f)
        {
            currentState = EnemyState.AttackPlayer;
        }
    }   

    void AttackPlayer()
    {
        agent.isStopped = true;

        if (sightSensor.detectedObject == null)
        {
            currentState = EnemyState.GoToBase;
            return;
        }

        Shoot();

        float distanceToPlayer = Vector3.Distance(transform.position, 
            sightSensor.detectedObject.transform.position);

        if (distanceToPlayer > playerAttackDistance * 1.1f)
        {
            currentState = EnemyState.ChasePlayer;
        }
    }

    void AttackBase()
    {
        agent.isStopped = true;
        LookTo(baseTransform.position);
        Shoot();
    }

    void Shoot()
    {
        var timeSinceLastShoot = Time.time - lastShootTime;
        if (timeSinceLastShoot > fireRate)
        return; 

        lastShootTime = Time.time;
        Instantiate(bulletPrefab, 
            transform.position, transform.rotation);
        muzzleEffect.Play();
    }

    void LookTo(Vector3 targetPosition)
    {
        Vector3 directionToPosition = Vector3.Normalize(
            targetPosition - transform.parent.position);
        directionToPosition.y = 0;
        transform.parent.forward = directionToPosition;
    }











}
