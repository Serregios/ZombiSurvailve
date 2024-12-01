using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZombiHP : MonoBehaviour
{
    public int Hp;
    [SerializeField] private UnityEvent getDamageEvent;
    [SerializeField] private AudioSource damageSound;
    private ZombieAI zombieAi;
    [SerializeField] private float destroyTime;
    void Start()
    {
        zombieAi = GetComponent<ZombieAI>();
    }
   void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            getDamageEvent.Invoke();
        }
    }
    public void PlayDamageSound()
    {
        if(damageSound.isPlaying == false)
        damageSound.Play();
    }
    public void GetDamage(int count)
    {
        Hp -= count;
        if (Hp <= 0)
        {
            zombieAi.ChangeState(zombieAi.zombieDeath);
            SpavnerZombie.totalZombie--;
            Destroy(gameObject, destroyTime);
        }
    }
}
