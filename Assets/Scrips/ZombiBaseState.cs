using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public abstract class ZombiBaseState : MonoBehaviour
{
    protected Animator animator;
    protected NavMeshAgent agent;
    protected Collider collider;
    protected ZombieAI zombieAi;
    protected float attackDistance = 2f;
    protected void Start()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        collider = GetComponent<Collider>();
        zombieAi = GetComponent<ZombieAI>();
    }
    public abstract void Actions();
}