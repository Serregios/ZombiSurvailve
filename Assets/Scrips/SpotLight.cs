using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLight : MonoBehaviour
{
    [SerializeField] Light spotlight;
    [SerializeField] AudioSource turnOnOff;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            turnOnOff.Play();
            if (spotlight.gameObject.activeInHierarchy)
            {
                spotlight.gameObject.SetActive(false);
            }
            else
            {
                spotlight.gameObject.SetActive(true);
            }
        }
       
    }
}
