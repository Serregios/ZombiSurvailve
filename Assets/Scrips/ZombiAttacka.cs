using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiAttacka : ZombiBaseState
{

    public override void Actions()
    {
        animator.SetBool("Run", false);
        animator.SetBool("Attack", true);
        agent.SetDestination(transform.position);

        if (Vector3.Distance(GameManager.instans.Player.transform.position, transform.position) > attackDistance)
        {
            zombieAi.ChangeState(zombieAi.zombieMovement);
        }
    }
}