using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gunnerShop : MonoBehaviour
{
    public Text gunnerShopp;
    gunnerAttack GunnerAttack;
    healthSystem HealthSystem;
    dmgManager dmgmanager;
    public GameObject gunner;
    public Text gunnerLevel;
    public Text gunnerDamage;
    public float Levelup;
    float calc;
    float basecost;
    characterSystem charactersystem;
    void Start()
    {
        HealthSystem = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        charactersystem = GameObject.Find("CharacterSystem").GetComponent<characterSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
        basecost = 1000;
        Levelup = basecost;
        gunnerLevel.text = "lvl" + gunnerAttack.levelGunner;
        gunnerDamage.text = 0 + "dps";
        gunnerShopp.text = Levelup + "g";
        gunner.SetActive(false);
        

    }
    public void Gunner()
    {

        if (healthSystem.gold >= Levelup)
        {
            characterSystem.currentCharacterBuy = 3;
            healthSystem.gold -= Levelup;
            gunnerAttack.levelGunner += 1;


            Levelup = Levelup + basecost * (float)1.45;

            gunnerLevel.text = "Lvl" + gunnerAttack.levelGunner;
            gunnerShopp.text = (int)Levelup - 1 + "G";
            dmgmanager.gunnerDamage = gunnerAttack.GunnerAttack;
        }
        else 
        {
            Debug.Log("za mało siana");
        }
    }
}
