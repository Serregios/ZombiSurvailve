using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpavnerZombie : MonoBehaviour
{
    [SerializeField] private GameObject zombie;
    [SerializeField] private float timeSpawn = 7f;
    [SerializeField] private int limitZombie = 20;
    private float timer;
    public static int totalZombie;
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(totalZombie);

        timer += Time.deltaTime;
        if (timer > timeSpawn)
        {
            if (totalZombie < limitZombie)
            {
                Instantiate(zombie, transform.position, transform.rotation);
                totalZombie++;
                timer = 0;
            }
        }
    }
}
