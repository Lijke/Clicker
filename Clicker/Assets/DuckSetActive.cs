using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSetActive : MonoBehaviour
{

    public bool activeDuck;
    public float timer = 0.0f;
    dmgManager damageManager;
    public void Start()
    {
        damageManager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
    }

    private void Update()
    {
        if (activeDuck == true)
        {
            if(timer< 1800)
            {
                damageManager.duckBonus = 2;
                timer += Time.deltaTime;
                int seconds = (int)timer % 60;
            }
            else if (timer > 1800)
            {
                timer = 0;
                activeDuck = false;
                damageManager.duckBonus = 1;
            }
            

        }
    }
    public void ActivateDuck()
    {
        if (activeDuck == false)
        activeDuck = true;
    }
}
