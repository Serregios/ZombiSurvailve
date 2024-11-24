using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovemt : ZombiBaseState
{
    public override void Actions()
    {
        animator.SetBool("Run", true);
        animator.SetBool("Attack", false);
        agent.SetDestination(GameManager.instans.Player.transform.position);

        if (Vector3.Distance(GameManager.instans.Player.transform.position, transform.position) < attackDistance)
        {
            zombieAi.ChangeState(zombieAi.zombieAttack);
        }

    }
}