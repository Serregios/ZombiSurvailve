using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    //NEW
    private ZombiBaseState currentState;
    public ZombiAttacka zombieAttack;
    public ZombieDeath zombieDeath;
    public ZombieMovemt zombieMovement;
    void Start()
    {
        //NEW
        zombieMovement = GetComponent<ZombieMovemt>();
        zombieDeath = GetComponent<ZombieDeath>();
        zombieAttack = GetComponent<ZombiAttacka>();
        ChangeState(zombieMovement);
    }

    void Update()
    {
        currentState.Actions();
    }

    //NEW
    public void ChangeState(ZombiBaseState state)
    {
        currentState = state;
    }
}