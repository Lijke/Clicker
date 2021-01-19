using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldierShop1 : MonoBehaviour
{
    public Text soldierShop;
    healthSystem HealthSystem;
    dmgManager dmgmanager;
    public GameObject solider;
    public Text soldierLevel;
    public Text soldierDamage;
    public float Levelup;
    float calc;
    float basecost;
    characterSystem charactersystem;
    void Awake()
    {
        soldierShop.text = "";
        HealthSystem = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        charactersystem = GameObject.Find("CharacterSystem").GetComponent<characterSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
        basecost = 650;
        
        Levelup = basecost;
        soldierLevel.text = "Lvl" + SoldierAttack.levelSoldier;
        soldierDamage.text = 0 + "dps";
        soldierShop.text = Levelup + "G";
        solider.SetActive(false);
        dmgmanager.soliderDamage = SoldierAttack.soldierAttack;

    }

    public void LevelUpSoldier()
    {

        if (healthSystem.gold >= Levelup)
        {
            characterSystem.currentCharacterBuy = 2;

            healthSystem.gold -= Levelup;
            SoldierAttack.levelSoldier += 1;

           
            Levelup = Levelup+ basecost *(float)1.45;

            soldierLevel.text = "Lvl" + SoldierAttack.levelSoldier;
            soldierShop.text = (int)Levelup-1 + "G";
            dmgmanager.soliderDamage = SoldierAttack.soldierAttack;
        }
        else
        {
            Debug.Log("za mało siana");
        }
    }
}
