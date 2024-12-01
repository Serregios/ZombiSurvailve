using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOver : MonoBehaviour
{
    public static GameOver Instanse;
    public UnityEvent GameOverEvent;
    void Awake()
    {
        Instanse = this;
    }

    void Update()
    {
        
    }
}
 