using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snowiShop : MonoBehaviour
{
    public Text snowiShopp;
    snowiAttack snowiAttack;
    healthSystem HealthSystem;
    dmgManager dmgmanager;
    public GameObject snowi;
    public Text snowiLevel;
    public Text snowiDamage;
    public float Levelup;
    float calc;
    float basecost;
    characterSystem charactersystem;

    void Start()
    {
        HealthSystem = GameObject.Find("HealthSystem").GetComponent<healthSystem>();
        charactersystem = GameObject.Find("CharacterSystem").GetComponent<characterSystem>();
        dmgmanager = GameObject.Find("DmgManager").GetComponent<dmgManager>();
        basecost = 4000;
        Levelup = basecost;
        snowiLevel.text = "lvl"+snowiAttack.levelSnowi;
        snowiShopp.text = Levelup + "g";
        snowi.SetActive(false);
    }

    public void LevelUpSnowi()
    {

        if (healthSystem.gold >= Levelup)
        {
            characterSystem.currentCharacterBuy = 4;

            healthSystem.gold -= Levelup;
            snowiAttack.levelSnowi += 1;


            Levelup = Levelup + basecost * (float)1.45;

            snowiLevel.text = "Lvl" + snowiAttack.levelSnowi;
            snowiShopp.text = (int)Levelup - 1 + "G";
            dmgmanager.snowiDamage = snowiAttack.SnowiAttack;
        }
        else
        {
            Debug.Log("za mało siana");
        }
    }
}
