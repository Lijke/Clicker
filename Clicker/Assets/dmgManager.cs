using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgManager : MonoBehaviour
{
    public float mageDamage;
    public float ninjaDamage;
    public float soliderDamage;
    public float currentMageDamage;
    public float currentSoldierDamage;
    public float currentNinjaDamage;
    public float gunnerDamage, currentGunnerDamage;
    public float allDamage;
    public float snowiDamage, currentSnowiDamage;
    public float pumpkinDamage, currentPumpkinDamage;
    public float DamageAll, Attack;
    healthSystem enemyhealth;
    public float duckBonus;
    //save
    Save save;
    public void Update()
    {
        if (currentMageDamage < mageDamage)
        { 
            calc();
            currentMageDamage = mageDamage;
            save.mage_Attack = mageDamage;
        }
            
        if (currentNinjaDamage < ninjaDamage)
        {
            calc();
            currentNinjaDamage = ninjaDamage;
            save.ninja_Attack = ninjaDamage;
        }

        if (currentSoldierDamage < soliderDamage)
        {
            calc();
            currentSoldierDamage = soliderDamage;
            save.soldier_Attack = soliderDamage;
        }
        if (currentGunnerDamage < gunnerDamage)
        {
            calc();
            currentSoldierDamage = gunnerDamage;
            save.Gunner_Attack_Save = gunnerDamage;
        }
        if (currentSnowiDamage < snowiDamage)
        {
            calc();
            currentSnowiDamage = snowiDamage;
            save.snowi_Attack = snowiDamage;
        }
        DamageAll = mageDamage + ninjaDamage + soliderDamage + snowiDamage + pumpkinDamage + gunnerDamage;

    }
    public void calc()
    {
        allDamage = currentMageDamage + currentNinjaDamage + currentSoldierDamage+currentSnowiDamage+currentPumpkinDamage+currentGunnerDamage;
    }
    private void Start()
    {
        save = GameObject.Find("SaveSystem").GetComponent<Save>(); 
        enemyhealth = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        duckBonus = 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Attack = DamageAll*duckBonus;
            enemyhealth.currentHealth -= Attack;
        }
    }

}
