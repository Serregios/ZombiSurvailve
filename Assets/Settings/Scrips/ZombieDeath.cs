using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieDeath : ZombiBaseState
{
    [SerializeField] AudioSource zombiAudiSource;
    public override void Actions()
    {
        animator.SetBool("Death", true);
        agent.isStopped = true;
        zombiAudiSource.Stop();
        collider.enabled = false;
    }
}