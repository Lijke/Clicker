using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    healthSystem healthsystem;
    // Start is called before the first frame update
    void Start()
    {
        healthsystem = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( healthsystem.currentHealth < 0)
        {
            
            Destroy(gameObject);
            healthsystem.isdead = true;
        }
    }
}
