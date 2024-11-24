using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBazyki : MonoBehaviour
{
    [SerializeField] private int damage = 5;
    [SerializeField] private Collider[] handBazyka;
    void Start()
    {
         
    }

    void Update()
    {
        
    }
    public void TakeDamage()
    {
        if (PlayerHp.Hp > 0)
        {
            PlayerHp.Hp -= damage;
        }
    }
    public void HandBazykiOff()
    {
        foreach (Collider collider in handBazyka)
        {
            collider.enabled = true;
        }
    }
    public void HandBazykiOn()
    {
        foreach (Collider collider in handBazyka)
        {
            collider.enabled = false;
        }
    }
}
