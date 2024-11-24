using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instans;

    public GameObject Player;
    private void Awake()
    {
        instans = this;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
